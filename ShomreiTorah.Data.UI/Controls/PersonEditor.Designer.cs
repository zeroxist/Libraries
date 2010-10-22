namespace ShomreiTorah.Data.UI.Controls {
	partial class PersonEditor {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.IdTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.contextBinder1 = new ShomreiTorah.Data.UI.Controls.ContextBinder();
			this.YKIDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
			this.LastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.HisNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.HerNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.FullNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.AddressTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.CityTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.StateComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
			this.ZipTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.PhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.SourceTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ItemForId = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForYKID = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForSource = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.ItemForLastName = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForHisName = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForHerName = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForFullName = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForAddress = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForCity = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForState = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForZip = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForPhone = new DevExpress.XtraLayout.LayoutControlItem();
			this.editorSettingsApplier1 = new ShomreiTorah.Data.UI.Controls.EditorSettingsApplier();
			this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
			this.dataLayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YKIDSpinEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LastNameTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HisNameTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HerNameTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FullNameTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CityTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StateComboBoxEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ZipTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SourceTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForYKID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForHisName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForHerName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForFullName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForCity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForState)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForZip)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.editorSettingsApplier1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
			this.SuspendLayout();
			// 
			// dataLayoutControl1
			// 
			this.dataLayoutControl1.Controls.Add(this.IdTextEdit);
			this.dataLayoutControl1.Controls.Add(this.YKIDSpinEdit);
			this.dataLayoutControl1.Controls.Add(this.LastNameTextEdit);
			this.dataLayoutControl1.Controls.Add(this.HisNameTextEdit);
			this.dataLayoutControl1.Controls.Add(this.HerNameTextEdit);
			this.dataLayoutControl1.Controls.Add(this.FullNameTextEdit);
			this.dataLayoutControl1.Controls.Add(this.AddressTextEdit);
			this.dataLayoutControl1.Controls.Add(this.CityTextEdit);
			this.dataLayoutControl1.Controls.Add(this.StateComboBoxEdit);
			this.dataLayoutControl1.Controls.Add(this.ZipTextEdit);
			this.dataLayoutControl1.Controls.Add(this.PhoneTextEdit);
			this.dataLayoutControl1.Controls.Add(this.SourceTextEdit);
			this.dataLayoutControl1.DataMember = "MasterDirectory";
			this.dataLayoutControl1.DataSource = this.contextBinder1;
			this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForId,
            this.ItemForYKID,
            this.ItemForSource});
			this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
			this.dataLayoutControl1.Name = "dataLayoutControl1";
			this.dataLayoutControl1.Root = this.layoutControlGroup1;
			this.dataLayoutControl1.Size = new System.Drawing.Size(412, 223);
			this.dataLayoutControl1.TabIndex = 0;
			this.dataLayoutControl1.Text = "dataLayoutControl1";
			// 
			// IdTextEdit
			// 
			this.IdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contextBinder1, "MasterDirectory.Id", true));
			this.IdTextEdit.Location = new System.Drawing.Point(0, 0);
			this.IdTextEdit.Name = "IdTextEdit";
			this.IdTextEdit.Size = new System.Drawing.Size(0, 20);
			this.IdTextEdit.StyleController = this.dataLayoutControl1;
			this.IdTextEdit.TabIndex = 4;
			// 
			// YKIDSpinEdit
			// 
			this.YKIDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contextBinder1, "MasterDirectory.YKID", true));
			this.YKIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.YKIDSpinEdit.Location = new System.Drawing.Point(0, 0);
			this.YKIDSpinEdit.Name = "YKIDSpinEdit";
			this.YKIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.YKIDSpinEdit.Size = new System.Drawing.Size(0, 20);
			this.YKIDSpinEdit.StyleController = this.dataLayoutControl1;
			this.YKIDSpinEdit.TabIndex = 5;
			// 
			// LastNameTextEdit
			// 
			this.LastNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contextBinder1, "MasterDirectory.LastName", true));
			this.LastNameTextEdit.Location = new System.Drawing.Point(66, 36);
			this.LastNameTextEdit.Name = "LastNameTextEdit";
			this.LastNameTextEdit.Size = new System.Drawing.Size(334, 20);
			this.LastNameTextEdit.StyleController = this.dataLayoutControl1;
			this.LastNameTextEdit.TabIndex = 6;
			// 
			// HisNameTextEdit
			// 
			this.HisNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contextBinder1, "MasterDirectory.HisName", true));
			this.HisNameTextEdit.Location = new System.Drawing.Point(66, 12);
			this.HisNameTextEdit.Name = "HisNameTextEdit";
			this.HisNameTextEdit.Size = new System.Drawing.Size(103, 20);
			this.HisNameTextEdit.StyleController = this.dataLayoutControl1;
			this.HisNameTextEdit.TabIndex = 7;
			// 
			// HerNameTextEdit
			// 
			this.HerNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contextBinder1, "MasterDirectory.HerName", true));
			this.HerNameTextEdit.Location = new System.Drawing.Point(227, 12);
			this.HerNameTextEdit.Name = "HerNameTextEdit";
			this.HerNameTextEdit.Size = new System.Drawing.Size(173, 20);
			this.HerNameTextEdit.StyleController = this.dataLayoutControl1;
			this.HerNameTextEdit.TabIndex = 8;
			// 
			// FullNameTextEdit
			// 
			this.FullNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contextBinder1, "MasterDirectory.FullName", true));
			this.FullNameTextEdit.Location = new System.Drawing.Point(78, 92);
			this.FullNameTextEdit.Name = "FullNameTextEdit";
			this.FullNameTextEdit.Size = new System.Drawing.Size(310, 20);
			this.FullNameTextEdit.StyleController = this.dataLayoutControl1;
			this.FullNameTextEdit.TabIndex = 9;
			// 
			// AddressTextEdit
			// 
			this.AddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contextBinder1, "MasterDirectory.Address", true));
			this.AddressTextEdit.Location = new System.Drawing.Point(78, 116);
			this.AddressTextEdit.Name = "AddressTextEdit";
			this.AddressTextEdit.Size = new System.Drawing.Size(310, 20);
			this.AddressTextEdit.StyleController = this.dataLayoutControl1;
			this.AddressTextEdit.TabIndex = 10;
			// 
			// CityTextEdit
			// 
			this.CityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contextBinder1, "MasterDirectory.City", true));
			this.CityTextEdit.Location = new System.Drawing.Point(78, 140);
			this.CityTextEdit.Name = "CityTextEdit";
			this.CityTextEdit.Size = new System.Drawing.Size(69, 20);
			this.CityTextEdit.StyleController = this.dataLayoutControl1;
			this.CityTextEdit.TabIndex = 11;
			// 
			// StateComboBoxEdit
			// 
			this.StateComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contextBinder1, "MasterDirectory.State", true));
			this.StateComboBoxEdit.Location = new System.Drawing.Point(205, 140);
			this.StateComboBoxEdit.Name = "StateComboBoxEdit";
			this.StateComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.StateComboBoxEdit.Properties.DropDownRows = 15;
			this.StateComboBoxEdit.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
			this.StateComboBoxEdit.Properties.Items.AddRange(new object[] {
            "NJ",
            "NY",
            "AK",
            "AL",
            "AR",
            "AZ",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "IA",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "MA",
            "MD",
            "ME",
            "MI",
            "MN",
            "MO",
            "MS",
            "MT",
            "NC",
            "ND",
            "NE",
            "NH",
            "NJ",
            "NM",
            "NV",
            "NY",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VA",
            "VT",
            "WA",
            "WI",
            "WV",
            "WY"});
			this.StateComboBoxEdit.Size = new System.Drawing.Size(50, 20);
			this.StateComboBoxEdit.StyleController = this.dataLayoutControl1;
			this.StateComboBoxEdit.TabIndex = 12;
			this.editorSettingsApplier1.SetUseDefaultSettings(this.StateComboBoxEdit, true);
			// 
			// ZipTextEdit
			// 
			this.ZipTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contextBinder1, "MasterDirectory.Zip", true));
			this.ZipTextEdit.Location = new System.Drawing.Point(313, 140);
			this.ZipTextEdit.Name = "ZipTextEdit";
			this.ZipTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
			this.ZipTextEdit.Properties.Mask.EditMask = "\\d{5}";
			this.ZipTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
			this.ZipTextEdit.Properties.Mask.ShowPlaceHolders = false;
			this.ZipTextEdit.Size = new System.Drawing.Size(75, 20);
			this.ZipTextEdit.StyleController = this.dataLayoutControl1;
			this.ZipTextEdit.TabIndex = 13;
			this.editorSettingsApplier1.SetUseDefaultSettings(this.ZipTextEdit, true);
			// 
			// PhoneTextEdit
			// 
			this.PhoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contextBinder1, "MasterDirectory.Phone", true));
			this.PhoneTextEdit.Location = new System.Drawing.Point(66, 176);
			this.PhoneTextEdit.Name = "PhoneTextEdit";
			this.PhoneTextEdit.Properties.Mask.EditMask = "\\(\\d\\d\\d\\) \\d\\d\\d - \\d\\d\\d\\d";
			this.PhoneTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
			this.PhoneTextEdit.Properties.Mask.ShowPlaceHolders = false;
			this.PhoneTextEdit.Size = new System.Drawing.Size(334, 20);
			this.PhoneTextEdit.StyleController = this.dataLayoutControl1;
			this.PhoneTextEdit.TabIndex = 14;
			this.editorSettingsApplier1.SetUseDefaultSettings(this.PhoneTextEdit, true);
			// 
			// SourceTextEdit
			// 
			this.SourceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contextBinder1, "MasterDirectory.Source", true));
			this.SourceTextEdit.Location = new System.Drawing.Point(0, 0);
			this.SourceTextEdit.Name = "SourceTextEdit";
			this.SourceTextEdit.Size = new System.Drawing.Size(0, 20);
			this.SourceTextEdit.StyleController = this.dataLayoutControl1;
			this.SourceTextEdit.TabIndex = 15;
			// 
			// ItemForId
			// 
			this.ItemForId.Control = this.IdTextEdit;
			this.ItemForId.CustomizationFormText = "Id";
			this.ItemForId.Location = new System.Drawing.Point(0, 0);
			this.ItemForId.Name = "ItemForId";
			this.ItemForId.Size = new System.Drawing.Size(0, 0);
			this.ItemForId.Text = "Id";
			this.ItemForId.TextSize = new System.Drawing.Size(50, 20);
			this.ItemForId.TextToControlDistance = 5;
			// 
			// ItemForYKID
			// 
			this.ItemForYKID.Control = this.YKIDSpinEdit;
			this.ItemForYKID.CustomizationFormText = "YKID";
			this.ItemForYKID.Location = new System.Drawing.Point(0, 0);
			this.ItemForYKID.Name = "ItemForYKID";
			this.ItemForYKID.Size = new System.Drawing.Size(0, 0);
			this.ItemForYKID.Text = "YKID";
			this.ItemForYKID.TextSize = new System.Drawing.Size(50, 20);
			this.ItemForYKID.TextToControlDistance = 5;
			// 
			// ItemForSource
			// 
			this.ItemForSource.Control = this.SourceTextEdit;
			this.ItemForSource.CustomizationFormText = "Source";
			this.ItemForSource.Location = new System.Drawing.Point(0, 0);
			this.ItemForSource.Name = "ItemForSource";
			this.ItemForSource.Size = new System.Drawing.Size(0, 0);
			this.ItemForSource.Text = "Source";
			this.ItemForSource.TextSize = new System.Drawing.Size(50, 20);
			this.ItemForSource.TextToControlDistance = 5;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(412, 223);
			this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup1.Text = "layoutControlGroup1";
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.AllowDrawBackground = false;
			this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
			this.layoutControlGroup2.GroupBordersVisible = false;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForPhone,
            this.ItemForHisName,
            this.ItemForHerName,
            this.ItemForLastName,
            this.layoutControlGroup3});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "autoGeneratedGroup0";
			this.layoutControlGroup2.Size = new System.Drawing.Size(392, 203);
			this.layoutControlGroup2.Text = "autoGeneratedGroup0";
			// 
			// ItemForLastName
			// 
			this.ItemForLastName.Control = this.LastNameTextEdit;
			this.ItemForLastName.CustomizationFormText = "Last Name";
			this.ItemForLastName.Location = new System.Drawing.Point(0, 24);
			this.ItemForLastName.Name = "ItemForLastName";
			this.ItemForLastName.Size = new System.Drawing.Size(392, 24);
			this.ItemForLastName.Text = "Last Name";
			this.ItemForLastName.TextSize = new System.Drawing.Size(50, 13);
			// 
			// ItemForHisName
			// 
			this.ItemForHisName.Control = this.HisNameTextEdit;
			this.ItemForHisName.CustomizationFormText = "His Name";
			this.ItemForHisName.Location = new System.Drawing.Point(0, 0);
			this.ItemForHisName.Name = "ItemForHisName";
			this.ItemForHisName.Size = new System.Drawing.Size(161, 24);
			this.ItemForHisName.Text = "His Name";
			this.ItemForHisName.TextSize = new System.Drawing.Size(50, 13);
			// 
			// ItemForHerName
			// 
			this.ItemForHerName.Control = this.HerNameTextEdit;
			this.ItemForHerName.CustomizationFormText = "Her Name";
			this.ItemForHerName.Location = new System.Drawing.Point(161, 0);
			this.ItemForHerName.Name = "ItemForHerName";
			this.ItemForHerName.Size = new System.Drawing.Size(231, 24);
			this.ItemForHerName.Text = "Her Name";
			this.ItemForHerName.TextSize = new System.Drawing.Size(50, 13);
			// 
			// ItemForFullName
			// 
			this.ItemForFullName.Control = this.FullNameTextEdit;
			this.ItemForFullName.CustomizationFormText = "Full Name";
			this.ItemForFullName.Location = new System.Drawing.Point(0, 0);
			this.ItemForFullName.Name = "ItemForFullName";
			this.ItemForFullName.Size = new System.Drawing.Size(368, 24);
			this.ItemForFullName.Text = "Full Name";
			this.ItemForFullName.TextSize = new System.Drawing.Size(50, 13);
			// 
			// ItemForAddress
			// 
			this.ItemForAddress.Control = this.AddressTextEdit;
			this.ItemForAddress.CustomizationFormText = "Address";
			this.ItemForAddress.Location = new System.Drawing.Point(0, 24);
			this.ItemForAddress.Name = "ItemForAddress";
			this.ItemForAddress.Size = new System.Drawing.Size(368, 24);
			this.ItemForAddress.Text = "Address";
			this.ItemForAddress.TextSize = new System.Drawing.Size(50, 13);
			// 
			// ItemForCity
			// 
			this.ItemForCity.Control = this.CityTextEdit;
			this.ItemForCity.CustomizationFormText = "City";
			this.ItemForCity.Location = new System.Drawing.Point(0, 48);
			this.ItemForCity.Name = "ItemForCity";
			this.ItemForCity.Size = new System.Drawing.Size(127, 24);
			this.ItemForCity.Text = "City";
			this.ItemForCity.TextSize = new System.Drawing.Size(50, 13);
			// 
			// ItemForState
			// 
			this.ItemForState.Control = this.StateComboBoxEdit;
			this.ItemForState.CustomizationFormText = "State";
			this.ItemForState.Location = new System.Drawing.Point(127, 48);
			this.ItemForState.MaxSize = new System.Drawing.Size(108, 24);
			this.ItemForState.MinSize = new System.Drawing.Size(108, 24);
			this.ItemForState.Name = "ItemForState";
			this.ItemForState.Size = new System.Drawing.Size(108, 24);
			this.ItemForState.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.ItemForState.Text = "State";
			this.ItemForState.TextSize = new System.Drawing.Size(50, 13);
			// 
			// ItemForZip
			// 
			this.ItemForZip.Control = this.ZipTextEdit;
			this.ItemForZip.CustomizationFormText = "Zip";
			this.ItemForZip.Location = new System.Drawing.Point(235, 48);
			this.ItemForZip.Name = "ItemForZip";
			this.ItemForZip.Size = new System.Drawing.Size(133, 24);
			this.ItemForZip.Text = "Zip";
			this.ItemForZip.TextSize = new System.Drawing.Size(50, 13);
			// 
			// ItemForPhone
			// 
			this.ItemForPhone.Control = this.PhoneTextEdit;
			this.ItemForPhone.CustomizationFormText = "Phone";
			this.ItemForPhone.Location = new System.Drawing.Point(0, 164);
			this.ItemForPhone.Name = "ItemForPhone";
			this.ItemForPhone.Size = new System.Drawing.Size(392, 39);
			this.ItemForPhone.Text = "Phone";
			this.ItemForPhone.TextSize = new System.Drawing.Size(50, 13);
			// 
			// layoutControlGroup3
			// 
			this.layoutControlGroup3.CustomizationFormText = "Mailing Address";
			this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForFullName,
            this.ItemForAddress,
            this.ItemForCity,
            this.ItemForState,
            this.ItemForZip});
			this.layoutControlGroup3.Location = new System.Drawing.Point(0, 48);
			this.layoutControlGroup3.Name = "layoutControlGroup3";
			this.layoutControlGroup3.Size = new System.Drawing.Size(392, 116);
			this.layoutControlGroup3.Text = "Mailing Address";
			// 
			// PersonEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataLayoutControl1);
			this.Name = "PersonEditor";
			this.Size = new System.Drawing.Size(412, 223);
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
			this.dataLayoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YKIDSpinEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LastNameTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HisNameTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HerNameTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FullNameTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CityTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StateComboBoxEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ZipTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SourceTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForYKID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForHisName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForHerName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForFullName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForCity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForState)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForZip)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.editorSettingsApplier1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private EditorSettingsApplier editorSettingsApplier1;
		private ContextBinder contextBinder1;
		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraEditors.TextEdit IdTextEdit;
		private DevExpress.XtraEditors.SpinEdit YKIDSpinEdit;
		private DevExpress.XtraEditors.TextEdit LastNameTextEdit;
		private DevExpress.XtraEditors.TextEdit HisNameTextEdit;
		private DevExpress.XtraEditors.TextEdit HerNameTextEdit;
		private DevExpress.XtraEditors.TextEdit FullNameTextEdit;
		private DevExpress.XtraEditors.TextEdit AddressTextEdit;
		private DevExpress.XtraEditors.TextEdit CityTextEdit;
		private DevExpress.XtraEditors.ComboBoxEdit StateComboBoxEdit;
		private DevExpress.XtraEditors.TextEdit ZipTextEdit;
		private DevExpress.XtraEditors.TextEdit PhoneTextEdit;
		private DevExpress.XtraEditors.TextEdit SourceTextEdit;
		private DevExpress.XtraLayout.LayoutControlItem ItemForId;
		private DevExpress.XtraLayout.LayoutControlItem ItemForYKID;
		private DevExpress.XtraLayout.LayoutControlItem ItemForSource;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem ItemForLastName;
		private DevExpress.XtraLayout.LayoutControlItem ItemForHisName;
		private DevExpress.XtraLayout.LayoutControlItem ItemForHerName;
		private DevExpress.XtraLayout.LayoutControlItem ItemForFullName;
		private DevExpress.XtraLayout.LayoutControlItem ItemForAddress;
		private DevExpress.XtraLayout.LayoutControlItem ItemForCity;
		private DevExpress.XtraLayout.LayoutControlItem ItemForState;
		private DevExpress.XtraLayout.LayoutControlItem ItemForZip;
		private DevExpress.XtraLayout.LayoutControlItem ItemForPhone;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
	}
}
