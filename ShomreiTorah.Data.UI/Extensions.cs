using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using DevExpress.Utils;
using ShomreiTorah.WinForms;

namespace ShomreiTorah.Data.UI {
	///<summary>Contains extension methods for data UIs.</summary>
	public static class Extensions {
		#region Tooltips
		///<summary>Creates a SuperToolTip that displays information about a person.</summary>
		public static SuperToolTip GetSuperTip(this Person person) {
			if (person == null) throw new ArgumentNullException("person");

			string body = person.MailingAddress;
			if (!string.IsNullOrEmpty(person.Phone))
				body += Environment.NewLine + Environment.NewLine + person.Phone;

			return Utilities.CreateSuperTip(person.VeryFullName, body);
		}

		///<summary>Creates a SuperToolTip that displays information about a deposit.</summary>
		public static SuperToolTip GetSuperTip(this Deposit deposit) {
			if (deposit == null) throw new ArgumentNullException("deposit");
			return Utilities.CreateSuperTip(
				body: String.Format(CultureInfo.CurrentCulture, "Deposit #{0} on {1:D}.\r\nDeposit contained {2:c} in {3} payments.",
																deposit.Number, deposit.Date, deposit.Payments.Sum(p => p.Amount), deposit.Payments.Count)
			);
		}
		#endregion
	}
}