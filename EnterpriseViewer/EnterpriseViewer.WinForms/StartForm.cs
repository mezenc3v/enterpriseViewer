using System;
using System.ComponentModel;
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
			_controller.PropertyChanged += PropertyChangedHandler;
			UpdateDepartmentsDataSource();
		}

		private void departmentTreeList_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
		{
			UpdateEmployeesDataSource();
		}

		private void saveBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			SaveChanges();
		}

		private void undoBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			UndoChanges();
			UpdateDepartmentsDataSource();
			UpdateEmployeesDataSource();
		}

		private void departmentTreeList_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
		{
			saveBarButton.Enabled = false;
		}

		private void employeeListBoxControl_DoubleClick(object sender, EventArgs e)
		{
			if (employeeListBoxControl.SelectedItem is EmployeeView employeeView)
			{
				var employeeForm = new EmployeeEditor(employeeView);
				employeeForm.Show(this);
			}
		}

		private void PropertyChangedHandler(object sender, PropertyChangedEventArgs args)
		{
			saveBarButton.Enabled = true;
			undoBarButton.Enabled = true;
		}

		private void StartForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.S)
			{
				SaveChanges();
			}
		}

		private void UpdateDepartmentsDataSource()
		{
			departmentsBindingSource.DataSource = _controller.Departments;
		}

		private void UpdateEmployeesDataSource()
		{
			var dep = departmentTreeList.GetFocusedRow() as DepartmentView;
			employeesBindingSource.DataSource = dep?.Employees;
		}

		private void SaveChanges()
		{
			_controller.SaveChanges();
			saveBarButton.Enabled = false;
			undoBarButton.Enabled = false;
		}

		private void UndoChanges()
		{
			_controller.Undo();
			saveBarButton.Enabled = false;
			undoBarButton.Enabled = false;
		}
	}
}
