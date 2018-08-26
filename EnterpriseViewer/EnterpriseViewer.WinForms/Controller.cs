using NLog;
using System;
using System.Linq;
using EnterpriseViewer.Data;
using System.ComponentModel;
using System.Collections.Generic;
using EnterpriseViewer.Model;
using EnterpriseViewer.WinForms.Annotations;
using EnterpriseViewer.WinForms.Presenters;

namespace EnterpriseViewer.WinForms
{
	public class Controller : INotifyPropertyChanged
	{
		private static readonly Logger Log = LogManager.GetCurrentClassLogger();
		private readonly IUnitOfWork _unitOfWork;
		private List<DepartmentView> _departmentViews;
		public IEnumerable<DepartmentView> Departments => _departmentViews ?? (_departmentViews = GetDepartments());
		public event PropertyChangedEventHandler PropertyChanged;

		public Controller([NotNull] IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
		}

		private List<DepartmentView> GetDepartments()
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

		public void Undo()
		{
			_unitOfWork.Undo();
			_departmentViews = null;
		}

		public DepartmentView AddNewDepartment([NotNull] DepartmentView parent)
		{
			if (parent == null) throw new ArgumentNullException(nameof(parent));

			var newDep = NewDepartment(parent.Department);
			var newDepView = new DepartmentView(newDep, new List<EmployeeView>());
			_departmentViews.Add(newDepView);
			return newDepView;
		}

		public void DeleteDepartment([NotNull] DepartmentView department)
		{
			if (department == null) throw new ArgumentNullException(nameof(department));
			_unitOfWork.DepartmentRepository.DeleteDepartment(department.Id);
			_departmentViews.Remove(department);
		}

		private Department NewDepartment(Department parent)
		{
			var newDep = new Department
			{
				Id = Guid.NewGuid(),
				Name = "New department",
				ParentId = parent?.Id
			};
			var dep = _unitOfWork.DepartmentRepository.AddDepartment(newDep);
			return dep;
		}

		private void PropertyChangedHandler(object sender, PropertyChangedEventArgs args)
		{
			PropertyChanged?.Invoke(sender, args);
			switch (sender)
			{
				case EmployeeView emp:
					 _unitOfWork.EmployeeRepository.UpdateEmployee(emp.Employee);
					break;
				case DepartmentView dep:
					_unitOfWork.DepartmentRepository.UpdateDepartment(dep.Department);
					break;
				
			}
		}
	}
}