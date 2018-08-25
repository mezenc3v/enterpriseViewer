using NLog;
using System;
using EnterpriseViewer.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EnterpriseViewer.WinForms.Annotations;
using EnterpriseViewer.WinForms.Presenters;

namespace EnterpriseViewer.WinForms
{
	public class Controller
	{
		private static readonly Logger Log = LogManager.GetCurrentClassLogger();

		private readonly IUnitOfWork _unitOfWork;

		public Controller([NotNull] IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
		}

		public IEnumerable<DepartmentView> GetDepartments()
		{
			var depViews = new List<DepartmentView>();
			var departments = _unitOfWork.DepartmentRepository.GetAllDepartments();
			foreach (var department in departments)
			{
				var employees = _unitOfWork.EmployeeRepository.GetEmployeesFromDepartment(department.Id);
				var employeeViews = employees.Select(e => new EmployeeView(e)).ToList();
				employeeViews.ForEach(ev =>
				{
					ev.PropertyChanged += PropertyChangedHandler;
				});

				var depView = new DepartmentView(department, employeeViews);
				depView.PropertyChanged += PropertyChangedHandler;
				depViews.Add(depView);
			}

			return depViews;
		}

		public void SaveChanges()
		{
			_unitOfWork.Commit();
		}

		private static void PropertyChangedHandler(object sender, PropertyChangedEventArgs args)
		{
			
		}
	}
}