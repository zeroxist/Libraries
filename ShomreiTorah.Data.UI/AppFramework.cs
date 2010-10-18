using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ShomreiTorah.Singularity;
using System.Windows.Forms;

namespace ShomreiTorah.Data.UI {
	///<summary>The base class for a standard ShomreiTorah application.</summary>
	public abstract class AppFramework {
		///<summary>Gets the AppFramework instance for the current application.</summary>
		///<remarks>This property is also available at design time.</remarks>
		public static AppFramework Current { get; private set; }

		bool isDesignTime = true;
		///<summary>Indicates whether the code is running in the Visual Studio designer.</summary>
		public bool IsDesignTime { get { return isDesignTime; } }

		///<summary>Registers an AppFramework instance for design time.</summary>
		protected static void RegisterDesignTime(AppFramework instance) {
			if (Current != null)
				throw new InvalidOperationException("An application is already registered");
			Current = instance;
			DisplaySettings.SettingsRegistrator.EnsureRegistered();
			instance.RegisterSettings();
		}

		///<summary>Gets the application's main form.</summary>
		public Form MainForm { get; private set; }

		ISplashScreen splashScreen;

		///<summary>Overridden by derived classes to create the application's splash screen.</summary>
		protected abstract ISplashScreen CreateSplash();
		///<summary>Overridden by derived classes to register grid and editor settings.</summary>
		protected abstract void RegisterSettings();
		///<summary>Creates the application's main form.</summary>
		protected abstract Form CreateMainForm();

		///<summary>Sets the splash screen's loading message, if supported.</summary>
		///<param name="message">A message to display on the splash screen.</param>
		protected void SetSplashCaption(string message) {
			if (splashScreen != null)
				splashScreen.SetCaption(message);
		}

		///<summary>Runs the application.</summary>
		protected void Run() {
			if (Current != null)
				throw new InvalidOperationException("An application is already running");
			isDesignTime = false;
			Current = this;

			StartSplash();
			SetSplashCaption("Loading behavior configuration");
			DisplaySettings.SettingsRegistrator.EnsureRegistered();
			RegisterSettings();
			//TODO: Updates, DataContext, Error handling

			MainForm = CreateMainForm();
			MainForm.Shown += delegate {
				if (splashScreen != null)
					splashScreen.CloseSplash();
				splashScreen = null;
			};
			Application.Run(MainForm);
		}
		///<summary>Shows the splash screen on a background thread.</summary>
		void StartSplash() {
			var splashThread = new Thread(delegate() {
				splashScreen = CreateSplash();
				splashScreen.RunSplash();
			}) { IsBackground = true };
			splashThread.SetApartmentState(ApartmentState.STA);
			splashThread.Start();
		}

		#region Row Activators
		readonly Dictionary<TableSchema, Action<Row>> rowActivators = new Dictionary<TableSchema, Action<Row>>();
		///<summary>Registers a details form for a Singularity schema.</summary>
		protected void RegisterRowDetail(TableSchema schema, Action<Row> activator) {
			if (schema == null) throw new ArgumentNullException("schema");
			if (activator == null) throw new ArgumentNullException("activator");
			rowActivators.Add(schema, activator);
		}
		///<summary>Registers a details form for a strongly typed Singularity schema.</summary>
		protected void RegisterRowDetail<TRow>(Action<TRow> activator) where TRow : Row {
			if (activator == null) throw new ArgumentNullException("activator");
			RegisterRowDetail(TypedSchema<TRow>.Instance, r => activator((TRow)r));
		}
		///<summary>Checks whether the given schema has an associated details form.</summary>
		public bool CanShowDetails(TableSchema schema) {
			if (schema == null) throw new ArgumentNullException("schema");

			return rowActivators.ContainsKey(schema);
		}
		///<summary>Shows a details form for a row in a Singularity table.</summary>
		public void ShowDetails(Row row) {
			if (row == null) throw new ArgumentNullException("row");
			rowActivators[row.Schema](row);
		}
		#endregion
	}

	///<summary>A class that displays a splash screen.</summary>
	public interface ISplashScreen {
		///<summary>Shows the splash screen.  This is a blocking call.</summary>
		void RunSplash();

		///<summary>Sets the splash screen's loading message, if supported.</summary>
		///<param name="message">A message to display on the splash screen.</param>
		void SetCaption(string message);

		///<summary>Indicates whether this splash screen can display a loading message.</summary>
		bool SupportsCaption { get; }

		///<summary>Closes the splash screen.</summary>
		void CloseSplash();
	}
}