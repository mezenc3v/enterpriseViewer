using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EnterpriseViewer.Model;

namespace EnterpriseViewer.WinForms.Presenters
{
	public class DepartmentView : INotifyPropertyChanged
	{
		public DepartmentView(Department department, List<EmployeeView> employees)
		{
			Department = department ?? throw new ArgumentNullException(nameof(department));
			Employees = employees ?? throw new ArgumentNullException(nameof(employees));
		}

		[Display(AutoGenerateField = false)]
		public Department Department { get; }

		[Display(AutoGenerateField = false)]
		public List<EmployeeView> Employees { get; }

		[Key]
		public Guid Id => Department.Id;

		public Guid? ParentId => Department.ParentId;

		[Display(Name = "Name", Description = "The name of the department.")]
		public string Name
		{
			get => Department.Name;
			set
			{
				Department.Name = value;
				Validate();
				OnPropertyChanged(nameof(Name));
			}
		}

		[Display(Name = "Code", Description = "The code of the department.")]
		public string Code
		{
			get => Department.Code;
			set
			{
				Department.Code = value;
				Validate();
				OnPropertyChanged(nameof(Code));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		private void Validate()
		{
			if (Name == null || Name.Length > 50)
			{
				throw new ArgumentException("Incorrect name!");
			}
			if (Code?.Length > 10)
			{
				throw new ArgumentException("Incorrect code!");
			}
		}
	}
}