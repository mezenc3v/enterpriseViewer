using System;
using System.Windows.Forms;
using EnterpriseViewer.WinForms.Annotations;
using EnterpriseViewer.WinForms.Presenters;

namespace EnterpriseViewer.WinForms
{
	public partial class StartForm : Form
	{
		private readonly Controller _controller;

		public StartForm([NotNull] Controller controller)
		{
			_controller = controller ?? throw new ArgumentNullException(nameof(controller));
			InitializeComponent();
			departmentsBindingSource.DataSource = _controller.Departments;
		}

		private void departmentTreeList_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
		{
			var dep = departmentTreeList.GetDataRecordByNode(e.Node) as DepartmentView;
			employeesBindingSource.DataSource = dep?.Employees;
		}

		private void departmentTreeList_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
		{
			saveBarButton.Enabled = true;
			undoBarButton.Enabled = true;
		}

		private void saveBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			_controller.SaveChanges();
			saveBarButton.Enabled = false;
			undoBarButton.Enabled = false;
		}

		private void undoBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			_controller.Undo();
			departmentsBindingSource.DataSource = _controller.Departments;
			saveBarButton.Enabled = false;
			undoBarButton.Enabled = false;
		}

		private void departmentTreeList_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
		{
			saveBarButton.Enabled = false;
		}
	}
}
