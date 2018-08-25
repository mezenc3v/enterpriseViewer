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
			using (var unitOfWork = UnitOfWorkFactory.CreateUnitOfWork())
			{
				var controller = new Controller(unitOfWork);
				var form = new StartForm(controller);
				Application.Run(form);
			}
		}
	}
}
