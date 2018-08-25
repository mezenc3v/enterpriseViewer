using EnterpriseViewer.Model;
using System;
using System.Collections.Generic;

namespace EnterpriseViewer.Data
{
	public interface IDepartmentRepository
	{
		IEnumerable<Department> GetAllDepartments();
		Department AddDepartment(Department department);
		Department GetDepartment(Guid departmentId);
		void DeleteDepartment(Guid departmentId);
		void UpdateDepartment(Department department);
	}
}