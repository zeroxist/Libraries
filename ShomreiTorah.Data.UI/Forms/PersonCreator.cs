using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShomreiTorah.WinForms;
using ShomreiTorah.Common;

namespace ShomreiTorah.Data.UI.Forms {
	///<summary>A form that allows the user to create a person.</summary>
	public partial class PersonCreator : XtraForm {
		PersonCreator(Person template = null) {
			InitializeComponent();
			personEditor.Person = template ?? new Person {
				Source = "Manually Added",
				City = "Passaic",
				State = "NJ",
				Zip = "07055",
				Phone = "973"
			};
		}
		///<summary>Raises the Shown event.</summary>
		protected override void OnShown(EventArgs e) {
			base.OnShown(e);
			//Set min/max regardless of skin sizing differences.
			MinimumSize = new Size(MinimumSize.Width, Height);
			MaximumSize = new Size(Screen.FromControl(this).WorkingArea.Width, Height);
		}

		private void ok_Click(object sender, EventArgs e) {
			//var columnErrors = Person.Schema.Columns.Select(c => personEditor.Person.ValidateValue(c, personEditor.Person[c]))
			//                                .Where(s => !String.IsNullOrEmpty(s));
			//if (columnErrors.Any()) {
			//    Dialog.ShowError(" • " + columnErrors.Join("\r\n • "));
			//    return;
			//}
			if (string.IsNullOrWhiteSpace(personEditor.Person.LastName)) {
				Dialog.ShowError("Please enter a last name");
				return;
			}
			if (string.IsNullOrWhiteSpace(personEditor.Person.FullName)) {
				Dialog.ShowError("Please enter a full name");
				return;
			}
			if (String.IsNullOrWhiteSpace(personEditor.Person.Phone) || personEditor.Person.Phone.Trim() == "973")
				personEditor.Person.Phone = "";
			try {
				AppFramework.Current.DataContext.Table<Person>().Rows.Add(personEditor.Person);
			} catch (InvalidOperationException ex) {
				Dialog.ShowError(ex.Message);
				return;
			}
			DialogResult = DialogResult.OK;
			Close();
		}

		///<summary>Prompts the user to create a new person.</summary>
		///<remarks>The new Person row, or null if the user clicked cancel.</remarks>
		public static Person Prompt(Person template = null) {
			using (var form = new PersonCreator(template)) {
				if (form.ShowDialog() == DialogResult.Cancel)
					return null;
				return form.personEditor.Person;
			}
		}
	}
}