using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EnterpriseViewer.WinForms.Annotations;
using EnterpriseViewer.WinForms.Presenters;

namespace EnterpriseViewer.WinForms
{
	public partial class StartForm : Form
	{
		private IEnumerable<DepartmentView> _departments;
		public void SetDepartments([NotNull] IEnumerable<DepartmentView> departments)
		{
			_departments = departments ?? throw new ArgumentNullException(nameof(departments));
			departmentsBindingSource.DataSource = _departments;
		}
		public StartForm()
		{
			InitializeComponent();
		}

		private void departmentTreeList_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
		{
			var dep = departmentTreeList.GetDataRecordByNode(e.Node) as DepartmentView;
			employeesBindingSource.DataSource = dep?.Employees;
		}
	}
}
