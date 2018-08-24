using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseViewer.WinForms
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var controller = new Controller(RepositoriesFactory.CreateDepartmentRepository(), RepositoriesFactory.CreateEmployeeRepository());
			var form = new StartForm();
			form.SetDepartments(controller.GetDepartments());
			Application.Run(form);
		}
	}
}
