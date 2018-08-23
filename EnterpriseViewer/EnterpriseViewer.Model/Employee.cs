using System;

namespace EnterpriseViewer.Model
{
	public class Employee
	{
		public decimal Id { get; set; }
		public Guid DepartmentId { get; set; }
		public string Surname { get; set; }
		public string FirstName { get; set; }
		public string Patronymic { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string DocSeries { get; set; }
		public string DocNumber { get; set; }
		public string Position { get; set; }
	}
}