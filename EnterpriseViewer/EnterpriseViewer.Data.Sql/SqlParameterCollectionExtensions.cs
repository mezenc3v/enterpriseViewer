using System;
using System.Data.SqlClient;

namespace EnterpriseViewer.Data.Sql
{
	public static class SqlParameterCollectionExtensions
	{
		public static SqlParameter AddWithNullValue(this SqlParameterCollection target, string parameterName, object value)
		{
			return target.AddWithValue(parameterName, value ?? DBNull.Value);
		}
	}
}