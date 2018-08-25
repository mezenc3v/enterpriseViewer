using System;

namespace EnterpriseViewer.Data
{
	public interface IUnitOfWork : IDisposable
	{
		IEmployeeRepository EmployeeRepository { get; }
		IDepartmentRepository DepartmentRepository { get; }
		void Commit();
		void Undo();
	}
}