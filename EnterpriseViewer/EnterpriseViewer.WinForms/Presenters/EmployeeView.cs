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

		public string FirstName
		{
			get => _employee.FirstName;
			set => _employee.FirstName = value;
		}

		public string Surname
		{
			get => _employee.Surname;
			set => _employee.Surname = value;
		}

		public string Patronymic
		{
			get => _employee.Patronymic;
			set => _employee.Patronymic = value;
		}

		public string DocSeries
		{
			get => _employee.DocSeries;
			set => _employee.DocSeries = value;
		}

		public string DocNumber
		{
			get => _employee.DocNumber;
			set => _employee.DocNumber = value;
		}

		public string Position
		{
			get => _employee.Position;
			set => _employee.Position = value;
		}

		public DateTime DateOfBirth
		{
			get => _employee.DateOfBirth;
			set => _employee.DateOfBirth = value;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}