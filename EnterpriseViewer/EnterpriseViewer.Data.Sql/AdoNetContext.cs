using System;
using System.Data.SqlClient;

namespace EnterpriseViewer.Data.Sql
{
	public class AdoNetContext: IDisposable
	{
		private SqlConnection _connection;
		private bool _ownsConnection;
		private SqlTransaction _transaction;

		public AdoNetContext(string connectionString, bool ownsConnection)
		{
			if (connectionString == null) throw new ArgumentNullException(nameof(connectionString));
			_connection = new SqlConnection(connectionString);
			_connection.Open();
			_ownsConnection = ownsConnection;
			_transaction = _connection.BeginTransaction();
		}

		public SqlCommand CreateCommand()
		{
			var cmd = _connection.CreateCommand();
			cmd.Transaction = _transaction;
			return cmd;
		}

		public void SaveChanges()
		{
			if (_transaction != null)
			{
				_transaction.Commit();
				_transaction = null;
			}
		}

		public void Dispose()
		{
			if (_transaction != null)
			{
				_transaction.Rollback();
				_transaction = null;
			}

			if (_connection != null && _ownsConnection)
			{
				_connection.Close();
				_connection = null;
			}
		}
	}
}