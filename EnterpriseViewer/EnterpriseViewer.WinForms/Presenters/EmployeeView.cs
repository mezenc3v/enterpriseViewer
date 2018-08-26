using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EnterpriseViewer.Model;

namespace EnterpriseViewer.WinForms.Presenters
{
	public class EmployeeView : INotifyPropertyChanged
	{
		public EmployeeView(Employee employee)
		{
			Employee = employee ?? throw new ArgumentNullException(nameof(employee));
		}

		[Display(AutoGenerateField = false)]
		public Employee Employee { get; }

		[Key]
		[Display(AutoGenerateField = false)]
		public decimal Id => Employee.Id;

		[Display(Name = "FullName", Description = "The Fullname of the employee.")]
		public string FullName => $"{Surname} {FirstName} {Patronymic}";

		[Display(Name = "FirstName", Description = "The firstname of the employee.")]
		public string FirstName
		{
			get => Employee.FirstName;
			set
			{
				Employee.FirstName = value;
				Validate();
				OnPropertyChanged(nameof(FirstName));
			}
		}

		[Display(Name = "Surname", Description = "The surname of the employee.")]
		public string Surname
		{
			get => Employee.Surname;
			set
			{
				Employee.Surname = value;
				Validate();
				OnPropertyChanged(nameof(Surname));
			}
		}

		[Display(Name = "Patronymic", Description = "The patronymic of the employee.")]
		public string Patronymic
		{
			get => Employee.Patronymic;
			set
			{
				Employee.Patronymic = value;
				Validate();
				OnPropertyChanged(nameof(Patronymic));
			}
		}

		[Display(Name = "DocSeries", Description = "The doc series of the employee.")]
		public string DocSeries
		{
			get => Employee.DocSeries;
			set
			{
				Employee.DocSeries = value;
				Validate();
				OnPropertyChanged(nameof(DocSeries));
			}
		}

		[Display(Name = "DocNumber", Description = "The doc number of the employee.")]
		public string DocNumber
		{
			get => Employee.DocNumber;
			set
			{
				Employee.DocNumber = value;
				Validate();
				OnPropertyChanged(nameof(DocNumber));
			}
		}

		[Display(Name = "Position", Description = "The position of the employee.")]
		public string Position
		{
			get => Employee.Position;
			set
			{
				Employee.Position = value;
				Validate();
				OnPropertyChanged(nameof(Position));
			}
		}

		[Display(Name = "DateOfBirth", Description = "Date of birth of the employee.")]
		public DateTime DateOfBirth
		{
			get => Employee.DateOfBirth;
			set
			{
				Employee.DateOfBirth = value;
				Validate();
				OnPropertyChanged(nameof(DateOfBirth));
			}
		}

		[Display(Name = "Age", Description = "Age of the employee.")]
		public string Age => $"{GetAge(Employee.DateOfBirth)} years old";

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		private void Validate()
		{
			if (Surname == null || Surname.Length > 50)
			{
				throw new ArgumentException("Incorrect surname!");
			}
			if (FirstName == null || FirstName.Length > 50)
			{
				throw new ArgumentException("Incorrect firstname!");
			}
			if (Patronymic?.Length > 50)
			{
				throw new ArgumentException("Incorrect patronymic!");
			}
			if (DocSeries?.Length > 4)
			{
				throw new ArgumentException("Incorrect doc series!");
			}
			if (DocNumber?.Length > 6)
			{
				throw new ArgumentException("Incorrect doc number!");
			}
			if (DateOfBirth == null)
			{
				throw new ArgumentException("Incorrect date of birth!");
			}
			if (Position == null)
			{
				throw new ArgumentException("Incorrect position!");
			}
		}

		private static int GetAge(DateTime birthDay)
		{
			int age = DateTime.Now.Year - birthDay.Year;

			if ((birthDay.Month > DateTime.Now.Month) || (birthDay.Month == DateTime.Now.Month && birthDay.Day > DateTime.Now.Day))
				age--;

			return age;
		}
	}
}