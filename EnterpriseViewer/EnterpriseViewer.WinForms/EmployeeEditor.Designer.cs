namespace EnterpriseViewer.WinForms
{
	partial class EmployeeEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.eployeeDataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.FullNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ItemForFullName = new DevExpress.XtraLayout.LayoutControlItem();
			this.FirstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ItemForFirstName = new DevExpress.XtraLayout.LayoutControlItem();
			this.SurnameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ItemForSurname = new DevExpress.XtraLayout.LayoutControlItem();
			this.PatronymicTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ItemForPatronymic = new DevExpress.XtraLayout.LayoutControlItem();
			this.DocSeriesTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ItemForDocSeries = new DevExpress.XtraLayout.LayoutControlItem();
			this.DocNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ItemForDocNumber = new DevExpress.XtraLayout.LayoutControlItem();
			this.PositionTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ItemForPosition = new DevExpress.XtraLayout.LayoutControlItem();
			this.DateOfBirthDateEdit = new DevExpress.XtraEditors.DateEdit();
			this.ItemForDateOfBirth = new DevExpress.XtraLayout.LayoutControlItem();
			this.AgeTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.ItemForAge = new DevExpress.XtraLayout.LayoutControlItem();
			this.employeeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eployeeDataLayoutControl)).BeginInit();
			this.eployeeDataLayoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FullNameTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForFullName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SurnameTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForSurname)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PatronymicTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForPatronymic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DocSeriesTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForDocSeries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DocNumberTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForDocNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PositionTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForPosition)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DateOfBirthDateEdit.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DateOfBirthDateEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForDateOfBirth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AgeTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForAge)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeViewBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.eployeeDataLayoutControl);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(510, 199, 650, 400);
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(514, 261);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(514, 261);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// eployeeDataLayoutControl
			// 
			this.eployeeDataLayoutControl.Controls.Add(this.FullNameTextEdit);
			this.eployeeDataLayoutControl.Controls.Add(this.FirstNameTextEdit);
			this.eployeeDataLayoutControl.Controls.Add(this.SurnameTextEdit);
			this.eployeeDataLayoutControl.Controls.Add(this.PatronymicTextEdit);
			this.eployeeDataLayoutControl.Controls.Add(this.DocSeriesTextEdit);
			this.eployeeDataLayoutControl.Controls.Add(this.DocNumberTextEdit);
			this.eployeeDataLayoutControl.Controls.Add(this.PositionTextEdit);
			this.eployeeDataLayoutControl.Controls.Add(this.DateOfBirthDateEdit);
			this.eployeeDataLayoutControl.Controls.Add(this.AgeTextEdit);
			this.eployeeDataLayoutControl.DataSource = this.employeeViewBindingSource;
			this.eployeeDataLayoutControl.Location = new System.Drawing.Point(12, 12);
			this.eployeeDataLayoutControl.Name = "eployeeDataLayoutControl";
			this.eployeeDataLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(352, 341, 650, 400);
			this.eployeeDataLayoutControl.Root = this.Root;
			this.eployeeDataLayoutControl.Size = new System.Drawing.Size(490, 237);
			this.eployeeDataLayoutControl.TabIndex = 4;
			this.eployeeDataLayoutControl.Text = "dataLayoutControl1";
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.eployeeDataLayoutControl;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(494, 241);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(490, 237);
			this.Root.TextVisible = false;
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.AllowDrawBackground = false;
			this.layoutControlGroup2.GroupBordersVisible = false;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForFullName,
            this.ItemForFirstName,
            this.ItemForSurname,
            this.ItemForPatronymic,
            this.ItemForDocSeries,
            this.ItemForDocNumber,
            this.ItemForPosition,
            this.ItemForDateOfBirth,
            this.ItemForAge});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "autoGeneratedGroup0";
			this.layoutControlGroup2.Size = new System.Drawing.Size(470, 217);
			// 
			// FullNameTextEdit
			// 
			this.FullNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeViewBindingSource, "FullName", true));
			this.FullNameTextEdit.Location = new System.Drawing.Point(79, 12);
			this.FullNameTextEdit.Name = "FullNameTextEdit";
			this.FullNameTextEdit.Properties.ReadOnly = true;
			this.FullNameTextEdit.Size = new System.Drawing.Size(399, 20);
			this.FullNameTextEdit.StyleController = this.eployeeDataLayoutControl;
			this.FullNameTextEdit.TabIndex = 4;
			// 
			// ItemForFullName
			// 
			this.ItemForFullName.Control = this.FullNameTextEdit;
			this.ItemForFullName.Location = new System.Drawing.Point(0, 0);
			this.ItemForFullName.Name = "ItemForFullName";
			this.ItemForFullName.Size = new System.Drawing.Size(470, 24);
			this.ItemForFullName.Text = "Full Name";
			this.ItemForFullName.TextSize = new System.Drawing.Size(63, 13);
			// 
			// FirstNameTextEdit
			// 
			this.FirstNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeViewBindingSource, "FirstName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.FirstNameTextEdit.Location = new System.Drawing.Point(79, 36);
			this.FirstNameTextEdit.Name = "FirstNameTextEdit";
			this.FirstNameTextEdit.Size = new System.Drawing.Size(399, 20);
			this.FirstNameTextEdit.StyleController = this.eployeeDataLayoutControl;
			this.FirstNameTextEdit.TabIndex = 5;
			// 
			// ItemForFirstName
			// 
			this.ItemForFirstName.Control = this.FirstNameTextEdit;
			this.ItemForFirstName.Location = new System.Drawing.Point(0, 24);
			this.ItemForFirstName.Name = "ItemForFirstName";
			this.ItemForFirstName.Size = new System.Drawing.Size(470, 24);
			this.ItemForFirstName.Text = "First Name";
			this.ItemForFirstName.TextSize = new System.Drawing.Size(63, 13);
			// 
			// SurnameTextEdit
			// 
			this.SurnameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeViewBindingSource, "Surname", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.SurnameTextEdit.Location = new System.Drawing.Point(79, 60);
			this.SurnameTextEdit.Name = "SurnameTextEdit";
			this.SurnameTextEdit.Size = new System.Drawing.Size(399, 20);
			this.SurnameTextEdit.StyleController = this.eployeeDataLayoutControl;
			this.SurnameTextEdit.TabIndex = 6;
			// 
			// ItemForSurname
			// 
			this.ItemForSurname.Control = this.SurnameTextEdit;
			this.ItemForSurname.Location = new System.Drawing.Point(0, 48);
			this.ItemForSurname.Name = "ItemForSurname";
			this.ItemForSurname.Size = new System.Drawing.Size(470, 24);
			this.ItemForSurname.Text = "Surname";
			this.ItemForSurname.TextSize = new System.Drawing.Size(63, 13);
			// 
			// PatronymicTextEdit
			// 
			this.PatronymicTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeViewBindingSource, "Patronymic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.PatronymicTextEdit.Location = new System.Drawing.Point(79, 84);
			this.PatronymicTextEdit.Name = "PatronymicTextEdit";
			this.PatronymicTextEdit.Size = new System.Drawing.Size(399, 20);
			this.PatronymicTextEdit.StyleController = this.eployeeDataLayoutControl;
			this.PatronymicTextEdit.TabIndex = 7;
			// 
			// ItemForPatronymic
			// 
			this.ItemForPatronymic.Control = this.PatronymicTextEdit;
			this.ItemForPatronymic.Location = new System.Drawing.Point(0, 72);
			this.ItemForPatronymic.Name = "ItemForPatronymic";
			this.ItemForPatronymic.Size = new System.Drawing.Size(470, 24);
			this.ItemForPatronymic.Text = "Patronymic";
			this.ItemForPatronymic.TextSize = new System.Drawing.Size(63, 13);
			// 
			// DocSeriesTextEdit
			// 
			this.DocSeriesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeViewBindingSource, "DocSeries", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DocSeriesTextEdit.Location = new System.Drawing.Point(79, 108);
			this.DocSeriesTextEdit.Name = "DocSeriesTextEdit";
			this.DocSeriesTextEdit.Size = new System.Drawing.Size(399, 20);
			this.DocSeriesTextEdit.StyleController = this.eployeeDataLayoutControl;
			this.DocSeriesTextEdit.TabIndex = 8;
			// 
			// ItemForDocSeries
			// 
			this.ItemForDocSeries.Control = this.DocSeriesTextEdit;
			this.ItemForDocSeries.Location = new System.Drawing.Point(0, 96);
			this.ItemForDocSeries.Name = "ItemForDocSeries";
			this.ItemForDocSeries.Size = new System.Drawing.Size(470, 24);
			this.ItemForDocSeries.Text = "Doc Series";
			this.ItemForDocSeries.TextSize = new System.Drawing.Size(63, 13);
			// 
			// DocNumberTextEdit
			// 
			this.DocNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeViewBindingSource, "DocNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DocNumberTextEdit.Location = new System.Drawing.Point(79, 132);
			this.DocNumberTextEdit.Name = "DocNumberTextEdit";
			this.DocNumberTextEdit.Size = new System.Drawing.Size(399, 20);
			this.DocNumberTextEdit.StyleController = this.eployeeDataLayoutControl;
			this.DocNumberTextEdit.TabIndex = 9;
			// 
			// ItemForDocNumber
			// 
			this.ItemForDocNumber.Control = this.DocNumberTextEdit;
			this.ItemForDocNumber.Location = new System.Drawing.Point(0, 120);
			this.ItemForDocNumber.Name = "ItemForDocNumber";
			this.ItemForDocNumber.Size = new System.Drawing.Size(470, 24);
			this.ItemForDocNumber.Text = "Doc Number";
			this.ItemForDocNumber.TextSize = new System.Drawing.Size(63, 13);
			// 
			// PositionTextEdit
			// 
			this.PositionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeViewBindingSource, "Position", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.PositionTextEdit.Location = new System.Drawing.Point(79, 156);
			this.PositionTextEdit.Name = "PositionTextEdit";
			this.PositionTextEdit.Size = new System.Drawing.Size(399, 20);
			this.PositionTextEdit.StyleController = this.eployeeDataLayoutControl;
			this.PositionTextEdit.TabIndex = 10;
			// 
			// ItemForPosition
			// 
			this.ItemForPosition.Control = this.PositionTextEdit;
			this.ItemForPosition.Location = new System.Drawing.Point(0, 144);
			this.ItemForPosition.Name = "ItemForPosition";
			this.ItemForPosition.Size = new System.Drawing.Size(470, 24);
			this.ItemForPosition.Text = "Position";
			this.ItemForPosition.TextSize = new System.Drawing.Size(63, 13);
			// 
			// DateOfBirthDateEdit
			// 
			this.DateOfBirthDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeViewBindingSource, "DateOfBirth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.DateOfBirthDateEdit.EditValue = null;
			this.DateOfBirthDateEdit.Location = new System.Drawing.Point(79, 180);
			this.DateOfBirthDateEdit.Name = "DateOfBirthDateEdit";
			this.DateOfBirthDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DateOfBirthDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DateOfBirthDateEdit.Size = new System.Drawing.Size(399, 20);
			this.DateOfBirthDateEdit.StyleController = this.eployeeDataLayoutControl;
			this.DateOfBirthDateEdit.TabIndex = 11;
			// 
			// ItemForDateOfBirth
			// 
			this.ItemForDateOfBirth.Control = this.DateOfBirthDateEdit;
			this.ItemForDateOfBirth.Location = new System.Drawing.Point(0, 168);
			this.ItemForDateOfBirth.Name = "ItemForDateOfBirth";
			this.ItemForDateOfBirth.Size = new System.Drawing.Size(470, 24);
			this.ItemForDateOfBirth.Text = "Date Of Birth";
			this.ItemForDateOfBirth.TextSize = new System.Drawing.Size(63, 13);
			// 
			// AgeTextEdit
			// 
			this.AgeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeViewBindingSource, "Age", true));
			this.AgeTextEdit.Location = new System.Drawing.Point(79, 204);
			this.AgeTextEdit.Name = "AgeTextEdit";
			this.AgeTextEdit.Properties.ReadOnly = true;
			this.AgeTextEdit.Size = new System.Drawing.Size(399, 20);
			this.AgeTextEdit.StyleController = this.eployeeDataLayoutControl;
			this.AgeTextEdit.TabIndex = 12;
			// 
			// ItemForAge
			// 
			this.ItemForAge.Control = this.AgeTextEdit;
			this.ItemForAge.Location = new System.Drawing.Point(0, 192);
			this.ItemForAge.Name = "ItemForAge";
			this.ItemForAge.Size = new System.Drawing.Size(470, 25);
			this.ItemForAge.Text = "Age";
			this.ItemForAge.TextSize = new System.Drawing.Size(63, 13);
			// 
			// employeeViewBindingSource
			// 
			this.employeeViewBindingSource.DataSource = typeof(EnterpriseViewer.WinForms.Presenters.EmployeeView);
			// 
			// EmployeeEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 261);
			this.Controls.Add(this.layoutControl1);
			this.Name = "EmployeeEditor";
			this.Text = "EmployeeEditor";
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eployeeDataLayoutControl)).EndInit();
			this.eployeeDataLayoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FullNameTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForFullName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SurnameTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForSurname)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PatronymicTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForPatronymic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DocSeriesTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForDocSeries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DocNumberTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForDocNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PositionTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForPosition)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DateOfBirthDateEdit.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DateOfBirthDateEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForDateOfBirth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AgeTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForAge)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeViewBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private System.Windows.Forms.BindingSource employeeViewBindingSource;
		private DevExpress.XtraDataLayout.DataLayoutControl eployeeDataLayoutControl;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraEditors.TextEdit FullNameTextEdit;
		private DevExpress.XtraEditors.TextEdit FirstNameTextEdit;
		private DevExpress.XtraEditors.TextEdit SurnameTextEdit;
		private DevExpress.XtraEditors.TextEdit PatronymicTextEdit;
		private DevExpress.XtraEditors.TextEdit DocSeriesTextEdit;
		private DevExpress.XtraEditors.TextEdit DocNumberTextEdit;
		private DevExpress.XtraEditors.TextEdit PositionTextEdit;
		private DevExpress.XtraEditors.DateEdit DateOfBirthDateEdit;
		private DevExpress.XtraEditors.TextEdit AgeTextEdit;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem ItemForFullName;
		private DevExpress.XtraLayout.LayoutControlItem ItemForFirstName;
		private DevExpress.XtraLayout.LayoutControlItem ItemForSurname;
		private DevExpress.XtraLayout.LayoutControlItem ItemForPatronymic;
		private DevExpress.XtraLayout.LayoutControlItem ItemForDocSeries;
		private DevExpress.XtraLayout.LayoutControlItem ItemForDocNumber;
		private DevExpress.XtraLayout.LayoutControlItem ItemForPosition;
		private DevExpress.XtraLayout.LayoutControlItem ItemForDateOfBirth;
		private DevExpress.XtraLayout.LayoutControlItem ItemForAge;
	}
}