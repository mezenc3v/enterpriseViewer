using System.Configuration;
using EnterpriseViewer.Data;
using EnterpriseViewer.Data.Sql;

namespace EnterpriseViewer.WinForms
{
	public class UnitOfWorkFactory
	{
		private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["TestDb"].ConnectionString;

		public static IUnitOfWork CreateUnitOfWork()
		{
			return new SqlUnitOfWork(ConnectionString);
		}
	}
}