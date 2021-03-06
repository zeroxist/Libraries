using System;
using System.Net;
using RazorEngine.Templating;
using RazorEngine.Text;
using ShomreiTorah.Data;

namespace ShomreiTorah.Statements.Email {
	public abstract class StatementTemplateBase : TemplateBase {
		///<summary>Gets the subject of the email.</summary>
		///<remarks>The email subject is shared by all partial pages, but can only be set by the main page.</remarks>
		public string EmailSubject {
			get { return ViewBag.EmailSubject; }
		}

		/// <summary>
		/// Includes the template with the specified name.
		/// </summary>
		/// <param name="cacheName">The name of the template type in cache.</param>
		/// <param name="model">The model or NULL if there is no model for the template.</param>
		/// <returns>The template writer helper.</returns>
		public override TemplateWriter Include(string cacheName, object model = null) {
			var instance = TemplateService.Resolve(cacheName, model);
			if (instance == null)
				throw new ArgumentException("No template could be resolved with name '" + cacheName + "'");

			return new TemplateWriter(tw => tw.Write(instance.Run(new ExecuteContext((DynamicViewBag)ViewBag))));
		}

		protected string ImageUrl(string name) {
			if (ImageService == null)
				throw new InvalidOperationException("The template host must provide an ImageServiceBase implementation.");
			return ImageService.GetUrl(name);
		}
		protected IEncodedString Image(string name, string alt) {
			return base.Raw("<img src=\"" + WebUtility.HtmlEncode(ImageUrl(name)) + "\" alt=\"" + WebUtility.HtmlEncode(alt) + "\" />");
		}
		protected IEncodedString MultiLine(string text) {
			return base.Raw(
				WebUtility.HtmlEncode(text).Replace("\r", "").Replace("\n", "<br />")
			);
		}

		// This property is set by the host on the ViewBag
		private ImageService ImageService { get { return ViewBag.ImageService; } }
	}

	///<summary>The base class used for partial views included by statement templates.</summary>
	public abstract class PartialPage : StatementTemplateBase {
		protected StatementInfo Info { get { return ViewBag.Info; } }
	}
	///<summary>The base class used for partial views with models included by statement templates.</summary>
	public abstract class PartialPage<TModel> : PartialPage, ITemplate<TModel> {
		public TModel Model { get; set; }
	}

	///<summary>The base class for statement template pages.  (entry points)</summary>
	public abstract class StatementPage : StatementTemplateBase {
		///<summary>Gets or sets the subject of the email.</summary>
		///<remarks>The email subject is shared by all partial pages, but can only be set by the main page.</remarks>
		public new string EmailSubject {
			get { return ViewBag.EmailSubject; }
			set { ViewBag.EmailSubject = value; }
		}

		///<summary>Indicates whether the email generated by the template should be sent.</summary>
		///<remarks>By default, this checks the StatementInfo; individual templates can override this property.</remarks>
		public virtual bool ShouldSend {
			get {
				if (Info == null)
					throw new InvalidOperationException("The template host must call SetInfo and render the page, and the template must set Kind, before the host can check ShouldSend");
				return Info.ShouldSend;
			}
		}

		internal void Log(string template, string userName) { Info.LogStatement("Email", template, userName); }

		///<summary>Called by the host to set the basic information about the statement being generated.</summary>
		///<remarks>This information is consumed when the template sets the Kind property.</remarks>
		public void SetInfo(Person person, DateTime startDate) {
			this.person = person;
			this.startDate = startDate;
		}

		///<summary>Called by the host, on the UI thread, before rendering any statements.  This must be idempotent.</summary>
		public virtual void Prepare(DateTime startDate) { }

		private DateTime startDate;
		private Person person;

		///<summary>Gets the data about the template being generated.</summary>
		///<remarks>This property is initialized when the template sets the Kind property.</remarks>
		protected StatementInfo Info { get; private set; }
		///<summary>Gets or sets the kind of statement that the template creates.  This property should be set exactly once by the template.</summary>
		protected StatementKind Kind {
			get {
				if (Info == null)
					throw new InvalidOperationException("Cannot read Kind before setting it");
				return Info.Kind;
			}
			set {
				if (person == null)
					throw new InvalidOperationException("The template host must call SetInfo before the template sets Kind");
				if (Info != null)
					throw new InvalidOperationException("The template must set Kind exactly once");

				ViewBag.Info = Info = new StatementInfo(person, startDate, value);
			}
		}

		///<summary>Called by the host to render the template.</summary>
		public string RenderPage(ImageService imageService) {
			return ((ITemplate)this).Run(new ExecuteContext() {
				ViewBag = {
					ImageService = imageService
				}
			});
		}
	}
}