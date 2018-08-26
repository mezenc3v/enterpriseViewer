using System;
using System.Windows.Forms;
using EnterpriseViewer.WinForms.Annotations;
using EnterpriseViewer.WinForms.Presenters;

namespace EnterpriseViewer.WinForms
{
	public partial class EmployeeEditor : Form
	{
		public EmployeeEditor([NotNull] EmployeeView employee)
		{
			InitializeComponent();
			employeeViewBindingSource.DataSource = employee;
		}
	}
}
