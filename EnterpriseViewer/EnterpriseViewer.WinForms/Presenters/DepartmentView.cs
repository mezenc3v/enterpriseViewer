using System;
using System.Collections.Generic;
using System.ComponentModel;
using EnterpriseViewer.Model;

namespace EnterpriseViewer.WinForms.Presenters
{
	public class DepartmentView : INotifyPropertyChanged
	{
		private readonly Department _department;
		public DepartmentView(Department department, IEnumerable<EmployeeView> employees)
		{
			_department = department ?? throw new ArgumentNullException(nameof(department));
			Employees = employees ?? throw new ArgumentNullException(nameof(employees));
		}

		public IEnumerable<EmployeeView> Employees { get; }

		public Guid Id => _department.Id;

		public Guid? ParentId => _department.ParentId;

		public string Name
		{
			get => _department.Name;
			set => _department.Name = value;
		}

		public string Code
		{
			get => _department.Code;
			set => _department.Code = value;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}