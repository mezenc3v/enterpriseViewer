using System;
using System.Collections.Generic;
using EnterpriseViewer.Model;
using System.Data.SqlClient;
using NLog;

namespace EnterpriseViewer.Data.Sql
{
	public class DepartmentRepository : IDepartmentRepository
	{
		internal static ILogger Logger = LogManager.GetCurrentClassLogger();
		private readonly string _connectionString;
		public DepartmentRepository(string connectionString)
		{
			_connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
		}

		public IEnumerable<Department> GetAllDepartments()
		{
			var result = new List<Department>();
			SqlConnection connection = null;
			try
			{
				connection = new SqlConnection(_connectionString);
				connection.Open();
				using (var command = connection.CreateCommand())
				{
					command.CommandText = "select ID from Department";
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							var departmentId = reader.GetGuid(reader.GetOrdinal("ID"));
							var department = GetDepartment(departmentId);
							result.Add(department);
						}
					}

					return result;
				}
			}
			catch (Exception e)
			{
				Logger.Error(e);
				throw;
			}
			finally
			{
				connection?.Dispose();
			}
		}

		public Department AddDepartment(Department department)
		{
			SqlConnection connection = null;
			try
			{
				var newDepartment = new Department
				{
					Id = department.Id,
					Name = department.Name,
					Code = department.Code,
					ParentId = department.ParentId,
				};

				connection = new SqlConnection(_connectionString);
				connection.Open();
				using (var cmd = connection.CreateCommand())
				{
					cmd.CommandText = @"insert into Department values (@ID,@Name,@Code,@ParentDepartmentID);";
					cmd.Parameters.AddWithValue("@ID", newDepartment.Id);
					cmd.Parameters.AddWithValue("@Name", newDepartment.Name);
					cmd.Parameters.AddWithValue("@Code", newDepartment.Code);
					cmd.Parameters.AddWithValue("@ParentDepartmentID", newDepartment.ParentId);
					cmd.ExecuteNonQuery();
				}
				return newDepartment;
			}
			catch (Exception e)
			{
				Logger.Error(e);
				throw;
			}
			finally
			{
				connection?.Dispose();
			}
		}

		public Department GetDepartment(Guid departmentId)
		{
			SqlConnection connection = null;
			try
			{
				connection = new SqlConnection(_connectionString);
				connection.Open();
				using (var command = connection.CreateCommand())
				{
					command.CommandText = "select ID, Name, Code, ParentDepartmentID from Department where ID = @departmentId;";
					command.Parameters.AddWithValue("@departmentId", departmentId);
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							return new Department
							{
								Id = reader.GetGuid(reader.GetOrdinal("ID")),
								Name = reader[reader.GetOrdinal("Name")] as string,
								Code = reader[reader.GetOrdinal("Code")] as string,
								ParentId = reader["ParentDepartmentID"] as Guid?,
							};
						}
					}
					throw new ArgumentException($"{nameof(Department)} with id {departmentId} not found");
				}
			}
			catch (Exception e)
			{
				Logger.Error(e);
				throw;
			}
			finally
			{
				connection?.Dispose();
			}
		}

		public void DeleteDepartment(Guid departmentId)
		{
			SqlConnection connection = null;
			try
			{
				connection = new SqlConnection(_connectionString);
				connection.Open();
				using (var cmd = connection.CreateCommand())
				{
					cmd.CommandText = "delete from Department where ID = @departmentId";
					cmd.Parameters.AddWithValue("@departmentId", departmentId);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception e)
			{
				Logger.Error(e);
				throw;
			}
			finally
			{
				connection?.Dispose();
			}
		}

		public void UpdateDepartment(Department department)
		{
			SqlConnection connection = null;
			try
			{
				connection = new SqlConnection(_connectionString);
				connection.Open();
				using (var cmd = connection.CreateCommand())
				{
					cmd.CommandText = "update Department set Name = @Name, Code = @Code, ParentDepartmentID = @ParentDepartmentID from Department where ID = @departmentId;";
					cmd.Parameters.AddWithValue("@Name", department.Name);
					cmd.Parameters.AddWithValue("@Code", department.Code);
					cmd.Parameters.AddWithValue("@departmentId", department.Id);
					cmd.Parameters.AddWithValue("@ParentDepartmentID", department.ParentId);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception e)
			{
				Logger.Error(e);
				throw;
			}
			finally
			{
				connection?.Dispose();
			}
		}
	}
}