using System;
using System.Collections.Generic;
using EnterpriseViewer.Model;

namespace EnterpriseViewer.Data
{
	public interface IEmployeeRepository
	{
		Employee AddEmployee(Employee employee);
		Employee GetEmployee(decimal employeeId);
		void DeleteEmployee(decimal employeeId);
		void UpdateEmployee(Employee employee);
		IEnumerable<Employee> GetEmployeesFromDepartment(Guid departmentId);
	}
}