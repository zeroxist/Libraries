using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Columns;
using System.ComponentModel;
using DevExpress.XtraEditors.Repository;
using System.Windows.Forms;

namespace ShomreiTorah.Data.UI.Grid {
	///<summary>A grid column that automatically reads column settings from metadata.</summary>
	public class SmartGridColumn : GridColumn {
		internal RepositoryItem DefaultEditor { get; set; }

		public bool ShouldSerializeColumnEditor() { return ColumnEdit != DefaultEditor; }
		public void ResetColumnEditor() { ColumnEdit = DefaultEditor; }

		///<summary>Gets or sets the repository item specifying the editor used to edit a column's cell values.</summary>
		[Category("Data")]
		[Description("Gets or sets the repository item specifying the editor used to edit a column's cell values.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[TypeConverter("DevExpress.XtraGrid.TypeConverters.ColumnEditConverter, " + AssemblyInfo.SRAssemblyGridDesign)]
		[Editor("DevExpress.XtraGrid.Design.ColumnEditEditor, " + AssemblyInfo.SRAssemblyGridDesign, typeof(System.Drawing.Design.UITypeEditor))]
		public RepositoryItem ColumnEditor {
			get { return base.ColumnEdit; }
			set { base.ColumnEdit = value; }
		}

		//In order to use ShouldSerialize & Reset, there cannot be a DefaultValueAttrubite.
		//Since attributes are inherited and cannot be removed from a base class,  I need a
		//new property with a different name.
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public new RepositoryItem ColumnEdit {
			get { return ColumnEditor; }
			set { ColumnEditor = value; }
		}
	}
}