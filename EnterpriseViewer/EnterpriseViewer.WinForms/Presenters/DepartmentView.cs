using System;
using System.Collections.Generic;
using System.ComponentModel;
using EnterpriseViewer.Model;

namespace EnterpriseViewer.WinForms.Presenters
{
	public class DepartmentView : INotifyPropertyChanged
	{
		public DepartmentView(Department department, IEnumerable<EmployeeView> employees)
		{
			Department = department ?? throw new ArgumentNullException(nameof(department));
			Employees = employees ?? throw new ArgumentNullException(nameof(employees));
		}

		public Department Department { get; }

		public IEnumerable<EmployeeView> Employees { get; }

		public Guid Id => Department.Id;

		public Guid? ParentId => Department.ParentId;

		public string Name
		{
			get => Department.Name;
			set
			{
				Department.Name = value;
				OnPropertyChanged(nameof(Name));
			}
		}

		public string Code
		{
			get => Department.Code;
			set
			{
				Department.Code = value;
				OnPropertyChanged(nameof(Code));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}