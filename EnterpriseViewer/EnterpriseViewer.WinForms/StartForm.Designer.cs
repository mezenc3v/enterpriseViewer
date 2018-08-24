namespace EnterpriseViewer.WinForms
{
	partial class StartForm
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
			this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.panel2 = new System.Windows.Forms.Panel();
			this.employeeListBox = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.departmentTreeList = new DevExpress.XtraTreeList.TreeList();
			this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.departmentTreeList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// departmentsBindingSource
			// 
			this.departmentsBindingSource.DataSource = typeof(EnterpriseViewer.WinForms.Presenters.DepartmentView);
			// 
			// employeesBindingSource
			// 
			this.employeesBindingSource.DataSource = typeof(EnterpriseViewer.WinForms.Presenters.EmployeeView);
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.panel2);
			this.layoutControl1.Controls.Add(this.panel1);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(539, 85, 650, 400);
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(484, 311);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.employeeListBox);
			this.panel2.Location = new System.Drawing.Point(333, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(139, 287);
			this.panel2.TabIndex = 5;
			// 
			// employeeListBox
			// 
			this.employeeListBox.DataSource = this.employeesBindingSource;
			this.employeeListBox.DisplayMember = "FirstName";
			this.employeeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.employeeListBox.FormattingEnabled = true;
			this.employeeListBox.Location = new System.Drawing.Point(0, 0);
			this.employeeListBox.Name = "employeeListBox";
			this.employeeListBox.Size = new System.Drawing.Size(139, 287);
			this.employeeListBox.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.departmentTreeList);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(312, 287);
			this.panel1.TabIndex = 4;
			// 
			// departmentTreeList
			// 
			this.departmentTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colCode});
			this.departmentTreeList.Cursor = System.Windows.Forms.Cursors.Default;
			this.departmentTreeList.DataSource = this.departmentsBindingSource;
			this.departmentTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.departmentTreeList.KeyFieldName = "Id";
			this.departmentTreeList.Location = new System.Drawing.Point(0, 0);
			this.departmentTreeList.Name = "departmentTreeList";
			this.departmentTreeList.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.DoubleClick;
			this.departmentTreeList.ParentFieldName = "ParentId";
			this.departmentTreeList.Size = new System.Drawing.Size(312, 287);
			this.departmentTreeList.TabIndex = 0;
			this.departmentTreeList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.departmentTreeList_FocusedNodeChanged);
			// 
			// colName
			// 
			this.colName.FieldName = "Name";
			this.colName.Name = "colName";
			this.colName.Visible = true;
			this.colName.VisibleIndex = 0;
			// 
			// colCode
			// 
			this.colCode.FieldName = "Code";
			this.colCode.Name = "colCode";
			this.colCode.Visible = true;
			this.colCode.VisibleIndex = 1;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.splitterItem1});
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(484, 311);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.panel1;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(316, 291);
			this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.panel2;
			this.layoutControlItem2.Location = new System.Drawing.Point(321, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(143, 291);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// splitterItem1
			// 
			this.splitterItem1.AllowHotTrack = true;
			this.splitterItem1.Location = new System.Drawing.Point(316, 0);
			this.splitterItem1.Name = "splitterItem1";
			this.splitterItem1.Size = new System.Drawing.Size(5, 291);
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 311);
			this.Controls.Add(this.layoutControl1);
			this.Name = "StartForm";
			this.Text = "Enterprise viewer";
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.departmentTreeList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource departmentsBindingSource;
		private System.Windows.Forms.BindingSource employeesBindingSource;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListBox employeeListBox;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraTreeList.TreeList departmentTreeList;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.SplitterItem splitterItem1;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colCode;
	}
}

