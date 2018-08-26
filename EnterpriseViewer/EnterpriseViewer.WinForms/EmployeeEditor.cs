using System;
using System.Windows.Forms;
using EnterpriseViewer.WinForms.Annotations;
using EnterpriseViewer.WinForms.Presenters;

namespace EnterpriseViewer.WinForms
{
	public partial class EmployeeEditor : Form
	{
		private readonly EmployeeView _employee;
		public EmployeeEditor([NotNull] EmployeeView employee)
		{
			_employee = employee ?? throw new ArgumentNullException(nameof(employee));
			InitializeComponent();
			employeeViewBindingSource.DataSource = _employee;
		}
	}
}
