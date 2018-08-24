using NLog;
using System;
using EnterpriseViewer.Data;
using System.Collections.Generic;
using System.Linq;
using EnterpriseViewer.WinForms.Annotations;
using EnterpriseViewer.WinForms.Presenters;

namespace EnterpriseViewer.WinForms
{
	public class Controller
	{
		private static readonly Logger Log = LogManager.GetCurrentClassLogger();

		private readonly IDepartmentRepository _departmentRepo;
		private readonly IEmployeeRepository _employeeRepo;

		public Controller([NotNull] IDepartmentRepository departmentRepo, [NotNull] IEmployeeRepository employeeRepo)
		{
			_departmentRepo = departmentRepo ?? throw new ArgumentNullException(nameof(departmentRepo));
			_employeeRepo = employeeRepo ?? throw new ArgumentNullException(nameof(employeeRepo));
		}

		public IEnumerable<DepartmentView> GetDepartments()
		{
			var depViews = new List<DepartmentView>();
			var departments = _departmentRepo.GetAllDepartments();
			foreach (var department in departments)
			{
				var employeeViews = _employeeRepo.GetEmployeesFromDepartment(department.Id).Select(e => new EmployeeView(e));
				var depView = new DepartmentView(department, employeeViews);
				depViews.Add(depView);
			}

			return depViews;
		}
	}
}