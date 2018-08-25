﻿using NLog;
using System;
using System.Linq;
using EnterpriseViewer.Data;
using System.ComponentModel;
using System.Collections.Generic;
using EnterpriseViewer.WinForms.Annotations;
using EnterpriseViewer.WinForms.Presenters;

namespace EnterpriseViewer.WinForms
{
	public class Controller
	{
		private static readonly Logger Log = LogManager.GetCurrentClassLogger();
		private readonly IUnitOfWork _unitOfWork;
		private IEnumerable<DepartmentView> _departmentViews;
		public IEnumerable<DepartmentView> Departments => _departmentViews ?? (_departmentViews = GetDepartments());

		public Controller([NotNull] IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
		}

		private IEnumerable<DepartmentView> GetDepartments()
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

		private void PropertyChangedHandler(object sender, PropertyChangedEventArgs args)
		{
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