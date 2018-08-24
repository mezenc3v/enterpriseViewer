using EnterpriseViewer.Data;
using EnterpriseViewer.Data.Sql;

namespace EnterpriseViewer.WinForms
{
	public class RepositoriesFactory
	{
		private const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = TestDB; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		public static IDepartmentRepository CreateDepartmentRepository()
		{
			return new DepartmentRepository(ConnectionString);
		}

		public static IEmployeeRepository CreateEmployeeRepository()
		{
			return new EmployeeRepository(ConnectionString);
		}
	}
}