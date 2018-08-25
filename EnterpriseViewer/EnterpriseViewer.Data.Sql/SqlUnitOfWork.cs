using System;

namespace EnterpriseViewer.Data.Sql
{
	public class SqlUnitOfWork : IUnitOfWork
	{
		private readonly AdoNetContext _context;
		private EmployeeRepository _employeeRepo;
		private DepartmentRepository _departmentRepo;

		public SqlUnitOfWork(string connectionString)
		{
			if (connectionString == null) throw new ArgumentNullException(nameof(connectionString));
			_context = new AdoNetContext(connectionString, true);
		}

		public IEmployeeRepository EmployeeRepository => _employeeRepo ?? (_employeeRepo = new EmployeeRepository(_context));


		public IDepartmentRepository DepartmentRepository => _departmentRepo ?? (_departmentRepo = new DepartmentRepository(_context));

		public void Commit()
		{
			_context.SaveChanges();
		}

		public void Undo()
		{
			_context.Undo();
		}

		#region IDisposable Support
		private bool _disposedValue;

		protected virtual void Dispose(bool disposing)
		{
			if (!_disposedValue)
			{
				if (disposing)
				{
					_context.Dispose();
				}
				_disposedValue = true;
			}
		}
		public void Dispose()
		{
			Dispose(true);
		}
		#endregion
	}
}