using System;
using EnterpriseViewer.Model;

namespace EnterpriseViewer.Data
{
	public interface IEmployeeRepository
	{
		Employee AddEmployee(Employee employee);
		Employee GetEmployee(decimal employeeId);
		void DeleteEmployee(decimal employeeId);
		void UpdateEmployee(Employee employee);
	}
}