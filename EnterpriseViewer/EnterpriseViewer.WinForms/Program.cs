using System;
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
			var unitOfWork = UnitOfWorkFactory.CreateUnitOfWork();
			var controller = new Controller(unitOfWork);
			var departments = controller.GetDepartments();
			var form = new StartForm();
			form.SetDepartments(departments);
			Application.Run(form);
		}
	}
}
