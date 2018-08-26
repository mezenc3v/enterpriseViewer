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
				employeeForm.ShowDialog(this);
			}
		}

		private void PropertyChangedHandler(object sender, PropertyChangedEventArgs args)
		{
			EnableSaveAndUndoBtns();
		}

		private void StartForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.S)
			{
				SaveChanges();
			}
		}

		private void addBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var dep = GetFocusedDepView();
			_controller.AddNewDepartment(dep);
			departmentTreeList.RefreshDataSource();
			EnableSaveAndUndoBtns();
		}

		private void deleteBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var dep = GetFocusedDepView();
			_controller.DeleteDepartment(dep);
			departmentTreeList.RefreshDataSource();
			EnableSaveAndUndoBtns();
		}

		private void UpdateDepartmentsDataSource()
		{
			departmentsBindingSource.DataSource = _controller.Departments;
		}

		private void UpdateEmployeesDataSource()
		{
			var dep = GetFocusedDepView();
			employeesBindingSource.DataSource = dep?.Employees;
		}

		private DepartmentView GetFocusedDepView()
		{
		   return departmentTreeList.GetFocusedRow() as DepartmentView;
		}

		private void SaveChanges()
		{
			_controller.SaveChanges();
			DisableSaveAndUndoBtns();
		}

		private void UndoChanges()
		{
			_controller.Undo();
			DisableSaveAndUndoBtns();
			UpdateEmployeesDataSource();
		}

		private void DisableSaveAndUndoBtns()
		{
			saveBarButton.Enabled = false;
			undoBarButton.Enabled = false;
		}

		private void EnableSaveAndUndoBtns()
		{
			saveBarButton.Enabled = true;
			undoBarButton.Enabled = true;
		}
	}
}
