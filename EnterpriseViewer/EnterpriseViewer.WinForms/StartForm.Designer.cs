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
			this.employeeListBoxControl = new DevExpress.XtraEditors.ListBoxControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.departmentTreeList = new DevExpress.XtraTreeList.TreeList();
			this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar4 = new DevExpress.XtraBars.Bar();
			this.saveBarButton = new DevExpress.XtraBars.BarButtonItem();
			this.undoBarButton = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.addBarButton = new DevExpress.XtraBars.BarButtonItem();
			this.deleteBarButton = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeeListBoxControl)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.departmentTreeList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
			this.layoutControl1.AllowCustomization = false;
			this.layoutControl1.Controls.Add(this.panel2);
			this.layoutControl1.Controls.Add(this.panel1);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 29);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(539, 86, 650, 400);
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(684, 332);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.employeeListBoxControl);
			this.panel2.Location = new System.Drawing.Point(471, 7);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(206, 318);
			this.panel2.TabIndex = 5;
			// 
			// employeeListBoxControl
			// 
			this.employeeListBoxControl.DataSource = this.employeesBindingSource;
			this.employeeListBoxControl.DisplayMember = "FullName";
			this.employeeListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.employeeListBoxControl.Location = new System.Drawing.Point(0, 0);
			this.employeeListBoxControl.Name = "employeeListBoxControl";
			this.employeeListBoxControl.Size = new System.Drawing.Size(206, 318);
			this.employeeListBoxControl.TabIndex = 0;
			this.employeeListBoxControl.DoubleClick += new System.EventHandler(this.employeeListBoxControl_DoubleClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.departmentTreeList);
			this.panel1.Location = new System.Drawing.Point(7, 7);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(455, 318);
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
			this.departmentTreeList.Size = new System.Drawing.Size(455, 318);
			this.departmentTreeList.TabIndex = 0;
			this.departmentTreeList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.departmentTreeList_FocusedNodeChanged);
			this.departmentTreeList.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.departmentTreeList_InvalidValueException);
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
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
			this.layoutControlGroup1.ShowInCustomizationForm = false;
			this.layoutControlGroup1.Size = new System.Drawing.Size(684, 332);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.panel1;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(459, 322);
			this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.panel2;
			this.layoutControlItem2.Location = new System.Drawing.Point(464, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(210, 322);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// splitterItem1
			// 
			this.splitterItem1.AllowHotTrack = true;
			this.splitterItem1.Location = new System.Drawing.Point(459, 0);
			this.splitterItem1.Name = "splitterItem1";
			this.splitterItem1.Size = new System.Drawing.Size(5, 322);
			// 
			// bar2
			// 
			this.bar2.BarName = "Main menu";
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.OptionsBar.MultiLine = true;
			this.bar2.OptionsBar.UseWholeRow = true;
			this.bar2.Text = "Main menu";
			// 
			// bar1
			// 
			this.bar1.BarName = "Custom 2";
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 0;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.Text = "Custom 2";
			// 
			// bar3
			// 
			this.bar3.BarName = "Custom 2";
			this.bar3.DockCol = 0;
			this.bar3.DockRow = 0;
			this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar3.Text = "Custom 2";
			// 
			// barManager1
			// 
			this.barManager1.AllowQuickCustomization = false;
			this.barManager1.AllowShowToolbarsPopup = false;
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.saveBarButton,
            this.undoBarButton,
            this.addBarButton,
            this.deleteBarButton});
			this.barManager1.MaxItemId = 4;
			// 
			// bar4
			// 
			this.bar4.BarItemVertIndent = 0;
			this.bar4.BarName = "Tools";
			this.bar4.DockCol = 0;
			this.bar4.DockRow = 0;
			this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.saveBarButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.undoBarButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.addBarButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteBarButton)});
			this.bar4.OptionsBar.AllowQuickCustomization = false;
			this.bar4.OptionsBar.DrawBorder = false;
			this.bar4.Text = "Tools";
			// 
			// saveBarButton
			// 
			this.saveBarButton.Caption = "Save";
			this.saveBarButton.Enabled = false;
			this.saveBarButton.Id = 0;
			this.saveBarButton.ImageOptions.ImageUri.Uri = "Save";
			this.saveBarButton.Name = "saveBarButton";
			this.saveBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveBarButton_ItemClick);
			// 
			// undoBarButton
			// 
			this.undoBarButton.Caption = "Undo";
			this.undoBarButton.Enabled = false;
			this.undoBarButton.Id = 1;
			this.undoBarButton.ImageOptions.ImageUri.Uri = "Undo";
			this.undoBarButton.Name = "undoBarButton";
			this.undoBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.undoBarButton_ItemClick);
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(684, 29);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 361);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(684, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 332);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(684, 29);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 332);
			// 
			// addBarButton
			// 
			this.addBarButton.Caption = "Add";
			this.addBarButton.Id = 2;
			this.addBarButton.ImageOptions.ImageUri.Uri = "Add";
			this.addBarButton.Name = "addBarButton";
			this.addBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBarButton_ItemClick);
			// 
			// deleteBarButton
			// 
			this.deleteBarButton.Caption = "Delete";
			this.deleteBarButton.Id = 3;
			this.deleteBarButton.ImageOptions.ImageUri.Uri = "Delete";
			this.deleteBarButton.Name = "deleteBarButton";
			this.deleteBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBarButton_ItemClick);
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 361);
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.KeyPreview = true;
			this.Name = "StartForm";
			this.Text = "Enterprise viewer";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.employeeListBoxControl)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.departmentTreeList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource departmentsBindingSource;
		private System.Windows.Forms.BindingSource employeesBindingSource;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraTreeList.TreeList departmentTreeList;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.SplitterItem splitterItem1;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colCode;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar4;
		private DevExpress.XtraBars.BarButtonItem saveBarButton;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem undoBarButton;
		private DevExpress.XtraEditors.ListBoxControl employeeListBoxControl;
		private DevExpress.XtraBars.BarButtonItem addBarButton;
		private DevExpress.XtraBars.BarButtonItem deleteBarButton;
	}
}

