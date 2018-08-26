using System;
using System.ComponentModel;
using EnterpriseViewer.Model;

namespace EnterpriseViewer.WinForms.Presenters
{
	public class EmployeeView : INotifyPropertyChanged
	{
		public EmployeeView(Employee employee)
		{
			Employee = employee ?? throw new ArgumentNullException(nameof(employee));
		}

		public Employee Employee { get; }

		public decimal Id => Employee.Id;

		public string FullName => $"{Surname} {FirstName} {Patronymic}";

		public string FirstName
		{
			get => Employee.FirstName;
			set
			{
				Employee.FirstName = value;
				OnPropertyChanged(nameof(FirstName));
			}
		}

		public string Surname
		{
			get => Employee.Surname;
			set
			{
				Employee.Surname = value;
				OnPropertyChanged(nameof(Surname));
			}
		}

		public string Patronymic
		{
			get => Employee.Patronymic;
			set
			{
				Employee.Patronymic = value;
				OnPropertyChanged(nameof(Patronymic));
			}
		}

		public string DocSeries
		{
			get => Employee.DocSeries;
			set
			{
				Employee.DocSeries = value;
				OnPropertyChanged(nameof(DocSeries));
			}
		}

		public string DocNumber
		{
			get => Employee.DocNumber;
			set
			{
				Employee.DocNumber = value;
				OnPropertyChanged(nameof(DocNumber));
			}
		}

		public string Position
		{
			get => Employee.Position;
			set
			{
				Employee.Position = value;
				OnPropertyChanged(nameof(Position));
			}
		}

		public DateTime DateOfBirth
		{
			get => Employee.DateOfBirth;
			set
			{
				Employee.DateOfBirth = value;
				OnPropertyChanged(nameof(DateOfBirth));
			}
		}

		public string Age => $"{GetAge(Employee.DateOfBirth)} years old";

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