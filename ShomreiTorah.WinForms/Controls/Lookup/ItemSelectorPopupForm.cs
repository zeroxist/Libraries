using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Collections;
using System.Drawing;
using DevExpress.XtraEditors.Popup;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.LookAndFeel;

namespace ShomreiTorah.WinForms.Controls.Lookup {
	class ItemSelectorPopupForm : CustomBlobPopupForm {
		public DevExpress.XtraEditors.VScrollBar ScrollBar { get; private set; }
		public IList Items { get { return OwnerEdit.AllItems; } }

		public ItemSelectorPopupForm(ItemSelector owner)
			: base(owner) {

			ScrollBar = new DevExpress.XtraEditors.VScrollBar();
			ScrollBar.ScrollBarAutoSize = true;
			ScrollBar.Scroll += ScrollBar_Scroll;
			ScrollBar.LookAndFeel.Assign(Properties.LookAndFeel);
			Controls.Add(ScrollBar);
		}

		protected override PopupBaseFormPainter CreatePainter() { return new ItemSelectorPopupFormPainter(); }
		protected override PopupBaseFormViewInfo CreateViewInfo() { return new ItemSelectorPopupFormViewInfo(this); }
		public new RepositoryItemItemSelector Properties { get { return (RepositoryItemItemSelector)base.Properties; } }
		public new ItemSelector OwnerEdit { get { return (ItemSelector)base.OwnerEdit; } }

		protected virtual void ScrollBar_Scroll(object sender, ScrollEventArgs e) {
			Invalidate();
		}

		public override void ShowPopupForm() {
			base.ShowPopupForm();
		}
		public override void ProcessKeyDown(KeyEventArgs e) {
			base.ProcessKeyDown(e);
			//TODO: Keyboard Navigation
		}
		//TODO: Mouse events (selection)

		protected override void UpdateControlPositionsCore() {
			base.UpdateControlPositionsCore();
			//TODO: Handle scrollbar?
		}
	}
	class ItemSelectorPopupFormViewInfo : CustomBlobPopupFormViewInfo {
		public ItemSelectorPopupFormViewInfo(ItemSelectorPopupForm form)
			: base(form) {
			AppearanceColumnHeader = new AppearanceObject();
			AppearanceResults = new AppearanceObject();
		}

		public new ItemSelectorPopupForm Form { get { return (ItemSelectorPopupForm)base.Form; } }

		#region Appearances
		bool IsSkinned { get { return Form.Properties.LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Skin; } }

		public AppearanceObject AppearanceColumnHeader { get; private set; }
		AppearanceDefault ColumnHeadersDefault {
			get {
				if (IsSkinned)
					return GridSkins.GetSkin(Form.LookAndFeel)[GridSkins.SkinHeader].GetAppearanceDefault();

				return new AppearanceDefault(GetSystemColor(SystemColors.ControlText), GetSystemColor(SystemColors.Control), HorzAlignment.Center, VertAlignment.Center);
			}
		}
		public AppearanceObject AppearanceResults { get; private set; }
		AppearanceObject ResultsDefault {
			get {
				var retVal = new AppearanceObject {
					ForeColor = GetSystemColor(SystemColors.ControlText),
					BackColor = GetSystemColor(SystemColors.Control)
				};
				retVal.TextOptions.Trimming = Trimming.EllipsisCharacter;
				return retVal;
			}
		}
		public override void UpdatePaintAppearance() {
			base.UpdatePaintAppearance();
			AppearanceHelper.Combine(AppearanceColumnHeader, new[] { Form.Properties.AppearanceColumnHeader, StyleController == null ? null :
																						  StyleController.AppearanceDropDownHeader }, ColumnHeadersDefault);
			AppearanceHelper.Combine(AppearanceResults, Form.Properties.AppearanceResults, ResultsDefault);
		}
		#endregion

		public int ScrollTop { get { return Form.ScrollBar.Visible ? Form.ScrollBar.Value : 0; } }

		public Rectangle RowsArea { get; private set; }
		public Rectangle HeaderArea { get; private set; }
		public int RowHeight { get; private set; }

		public int FirstVisibleRow { get { return ScrollTop / RowHeight; } }
		//public int VisibleRows { get { return Math.Min(Form.Items.Count,  RowsArea.Height / RowHeight); } }

		public IEnumerable<ResultColumn> VisibleColumns { get { return Form.Properties.Columns.Where(c => c.Visible); } }

		public int GetRowCoordinate(int rowIndex) {
			return RowsArea.Top + (rowIndex * RowHeight) - ScrollTop;
		}

		protected override void CalcContentRect(Rectangle bounds) {
			base.CalcContentRect(bounds);

			var headerHeight = Form.Properties.ShowColumnHeaders ? 20 : 0;
			RowHeight = 20;	//TODO: Calculate
			var rowAreaHeight = ContentRect.Height - headerHeight;

			Form.ScrollBar.Maximum = RowHeight * Form.Items.Count;
			Form.ScrollBar.Visible = Form.ScrollBar.Maximum > rowAreaHeight;

			int availableWidth = ContentRect.Width;
			if (Form.ScrollBar.Visible) {
				availableWidth -= Form.ScrollBar.Width;

				Form.ScrollBar.Left = ContentRect.Width - Form.ScrollBar.Width;
				Form.ScrollBar.Top = ContentRect.Top + headerHeight;
				Form.ScrollBar.Height = rowAreaHeight;
			}

			HeaderArea = new Rectangle(ContentRect.Location, new Size(availableWidth, headerHeight));
			RowsArea = new Rectangle(HeaderArea.Left, HeaderArea.Bottom, availableWidth, rowAreaHeight);
		}
	}
	class ItemSelectorPopupFormPainter : PopupBaseSizeableFormPainter {
		protected override void DrawContent(PopupFormGraphicsInfoArgs info) {
			base.DrawContent(info);

			var vi = (ItemSelectorPopupFormViewInfo)info.ViewInfo;
			if (vi.Form.Properties.ShowColumnHeaders)
				DrawColumnHeaders(info);
			DrawRows(info);
		}

		void DrawColumnHeaders(PopupFormGraphicsInfoArgs args) {
			var info = (ItemSelectorPopupFormViewInfo)args.ViewInfo;
		}
		void DrawRows(PopupFormGraphicsInfoArgs args) {

			var info = (ItemSelectorPopupFormViewInfo)args.ViewInfo;
			using (args.Cache.ClipInfo.SaveAndSetClip(info.RowsArea)) {

				for (int rowIndex = info.FirstVisibleRow; rowIndex < info.Form.Items.Count; rowIndex++) {
					int y = info.GetRowCoordinate(rowIndex);		//TODO: Selection
					if (y > info.RowsArea.Bottom) break;

					DrawRow(args, rowIndex);
				}
			}
		}
		void DrawRow(PopupFormGraphicsInfoArgs args, int rowIndex) {
			var info = (ItemSelectorPopupFormViewInfo)args.ViewInfo;

			int y = info.GetRowCoordinate(rowIndex);		//TODO: Selection

			int x = info.RowsArea.X;
			foreach (var column in info.VisibleColumns) {
				DrawCell(args, rowIndex, column, x);

				x += column.Width + 4;
			}
		}

		void DrawCell(PopupFormGraphicsInfoArgs args, int rowIndex, ResultColumn column, int x) {
			var info = (ItemSelectorPopupFormViewInfo)args.ViewInfo;

			var location = new Point(x, info.GetRowCoordinate(rowIndex));
			var cellWidth = Math.Min(column.Width, info.RowsArea.Right - x);
			var cellBounds = new Rectangle(location, new Size(cellWidth, info.RowHeight));

			var text = column.GetValue(info.Form.Items[rowIndex]);

			info.AppearanceResults.DrawString(args.Cache, text, cellBounds);
		}
	}
}
