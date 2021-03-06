using System;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace ShomreiTorah.WinForms {
	///<summary>Manages a checkbox column in a grid.</summary>
	public class CheckableGridController {
		///<summary>Gets the column that contains the checkboxes.</summary>
		public GridColumn CheckColumn { get; private set; }

		///<summary>Gets the grid view being controlled.</summary>
		public GridView View { get { return (GridView)CheckColumn.View; } }

		///<summary>Creates a CheckableGridController that manages the checkboxes in a grid column.</summary>
		///<remarks>Calling this is prettier than `new CheckableGridController(column).ToString()`.</remarks>
		public static CheckableGridController Handle(GridColumn checkColumn) { return new CheckableGridController(checkColumn); }

		///<summary>Creates a CheckableGridController that manages the checkboxes in a grid column.</summary>
		public CheckableGridController(GridColumn checkColumn) {
			if (checkColumn == null) throw new ArgumentNullException("checkColumn");

			CheckColumn = checkColumn;
			CheckColumn.OptionsColumn.AllowEdit = false;
			CheckColumn.ShowButtonMode = ShowButtonModeEnum.ShowAlways;

			View.BeforeLeaveRow += View_BeforeLeaveRow;
			View.KeyPress += View_KeyPress;
			View.MouseUp += View_MouseUp;
		}

		///<summary>Inverts the checkbox of the given row handle.</summary>
		public void Invert(int rowHandle) {
			if (View.IsGroupRow(rowHandle)) {
				for (int i = 0; i < View.GetChildRowCount(rowHandle); i++)
					Invert(View.GetChildRowHandle(rowHandle, i));
			} else
				View.SetRowCellValue(rowHandle, CheckColumn, !(bool)View.GetRowCellValue(rowHandle, CheckColumn));
		}

		void View_MouseUp(object sender, MouseEventArgs e) {
			var hitInfo = View.CalcHitInfo(e.Location);
			if (hitInfo.Column == CheckColumn && hitInfo.RowHandle >= 0 && hitInfo.HitTest == GridHitTest.RowCell) {
				Invert(hitInfo.RowHandle);

				var dx = e as DXMouseEventArgs;
				if (dx != null) dx.Handled = true;
			}
		}

		void View_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.Handled) return;
			if (e.KeyChar == ' ') {
				//Without this, checking rows will move them
				//around if the column is sorted, messing up
				//the row handles.
				View.BeginDataUpdate();
				foreach (var handle in View.GetSelectedRows())
					Invert(handle);
				View.EndDataUpdate();

				e.Handled = true;
			}
		}

		void View_BeforeLeaveRow(object sender, RowAllowEventArgs e) {
			if (Control.MouseButtons == MouseButtons.Left) {	//Don't change focus when a checkbox is clicked
				var hitInfo = View.CalcHitInfo(View.GridControl.PointToClient(Control.MousePosition));
				if (hitInfo.Column == CheckColumn && hitInfo.HitTest == GridHitTest.RowCell)
					e.Allow = false;
			}
		}
	}
}
