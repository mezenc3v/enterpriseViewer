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
			var focusedNode = GetFocusedDepView();
			deleteDepBarButton.Enabled = focusedNode != null;
			deleteEmpBarBtn.Enabled = focusedNode != null;
			addEmpBarBtn.Enabled = focusedNode != null;
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
			EnableSaveAndUndoDepBtns();
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
			EnableSaveAndUndoDepBtns();
		}

		private void deleteBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var dep = GetFocusedDepView();
			_controller.DeleteDepartment(dep);
			UpdateDepartmentsDataSource();
			departmentTreeList.RefreshDataSource();
			EnableSaveAndUndoDepBtns();
		}

		private void addEmpBarBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var dep = GetFocusedDepView();
			_controller.AddNewEmployee(dep);
			employeeListBoxControl.Refresh();
			EnableSaveAndUndoDepBtns();
		}

		private void deleteEmpBarBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (employeeListBoxControl.SelectedItem is EmployeeView employeeView)
			{
				var prevIndex = GetPrevEmployeeIndex();
				_controller.DeleteEmployee(employeeView);
				employeeListBoxControl.Refresh();
				employeeListBoxControl.SelectedIndex = prevIndex;
				EnableSaveAndUndoDepBtns();
			}
		}

		private void employeeListBoxControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			deleteEmpBarBtn.Enabled = employeeListBoxControl.SelectedIndex != -1;
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
			DisableSaveAndUndoDepBtns();
		}

		private void UndoChanges()
		{
			_controller.Undo();
			DisableSaveAndUndoDepBtns();
			UpdateEmployeesDataSource();
		}

		private void DisableSaveAndUndoDepBtns()
		{
			saveBarButton.Enabled = false;
			undoBarButton.Enabled = false;
		}

		private void EnableSaveAndUndoDepBtns()
		{
			saveBarButton.Enabled = true;
			undoBarButton.Enabled = true;
		}

		private int GetPrevEmployeeIndex()
		{
			var prevIndex = employeeListBoxControl.SelectedIndex - 1;
			if (prevIndex == -1)
				prevIndex = 0;

			return prevIndex;
		}
	}
}
