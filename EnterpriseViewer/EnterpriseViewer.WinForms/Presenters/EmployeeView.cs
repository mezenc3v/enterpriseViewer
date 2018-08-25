using System;
using System.ComponentModel;
using EnterpriseViewer.Model;

namespace EnterpriseViewer.WinForms.Presenters
{
	public class EmployeeView : INotifyPropertyChanged
	{
		private readonly Employee _employee;

		public EmployeeView(Employee employee)
		{
			_employee = employee ?? throw new ArgumentNullException(nameof(employee));
		}

		public decimal Id => _employee.Id;

		public string FullName => $"{Surname} {FirstName} {Patronymic}";

		public string FirstName
		{
			get => _employee.FirstName;
			set
			{
				_employee.FirstName = value;
				OnPropertyChanged(nameof(FirstName));
			}
		}

		public string Surname
		{
			get => _employee.Surname;
			set
			{
				_employee.Surname = value;
				OnPropertyChanged(nameof(Surname));
			}
		}

		public string Patronymic
		{
			get => _employee.Patronymic;
			set
			{
				_employee.Patronymic = value;
				OnPropertyChanged(nameof(Patronymic));
			}
		}

		public string DocSeries
		{
			get => _employee.DocSeries;
			set
			{
				_employee.DocSeries = value;
				OnPropertyChanged(nameof(DocSeries));
			}
		}

		public string DocNumber
		{
			get => _employee.DocNumber;
			set
			{
				_employee.DocNumber = value;
				OnPropertyChanged(nameof(DocNumber));
			}
		}

		public string Position
		{
			get => _employee.Position;
			set
			{
				_employee.Position = value;
				OnPropertyChanged(nameof(Position));
			}
		}

		public DateTime DateOfBirth
		{
			get => _employee.DateOfBirth;
			set
			{
				_employee.DateOfBirth = value;
				OnPropertyChanged(nameof(DateOfBirth));
			}
		}

		public int Age => GetAge(_employee.DateOfBirth);

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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