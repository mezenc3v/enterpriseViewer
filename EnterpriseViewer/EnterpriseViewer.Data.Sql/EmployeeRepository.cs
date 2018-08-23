using System;
using System.Data;
using EnterpriseViewer.Model;
using System.Data.SqlClient;
using NLog;

namespace EnterpriseViewer.Data.Sql
{
	public class EmployeeRepository : IEmployeeRepository
	{
		internal static ILogger Logger = LogManager.GetCurrentClassLogger();
		private readonly string _connectionString;
		public EmployeeRepository(string connectionString)
		{
			_connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
		}

		public Employee AddEmployee(Employee employee)
		{
			SqlConnection connection = null;
			try
			{
				var newEmployee = new Employee
				{
					FirstName = employee.FirstName,
					Surname = employee.Surname,
					Patronymic = employee.Patronymic,
					DateOfBirth = employee.DateOfBirth,
					DocSeries = employee.DocSeries,
					DocNumber = employee.DocNumber,
					Position = employee.Position,
					DepartmentId = employee.DepartmentId
				};

				connection = new SqlConnection(_connectionString);
				connection.Open();
				using (var cmd = connection.CreateCommand())
				{
					cmd.CommandText = @"insert into Empoyee values (@FirstName,@SurName,@Patronymic,@DateOfBirth,@DocSeries,@DocNumber,@Position,@DepartmentID); SET @ID = SCOPE_IDENTITY()";
					cmd.Parameters.Add("@ID", SqlDbType.Int, 5).Direction = ParameterDirection.Output;
					cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
					cmd.Parameters.AddWithValue("@SurName", employee.Surname);
					cmd.Parameters.AddWithValue("@Patronymic", employee.Patronymic);
					cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth);
					cmd.Parameters.AddWithValue("@DocSeries", employee.DocSeries);
					cmd.Parameters.AddWithValue("@DocNumber", employee.DocNumber);
					cmd.Parameters.AddWithValue("Position", employee.Position);
					cmd.Parameters.AddWithValue("@DepartmentID", employee.DepartmentId);
					cmd.ExecuteNonQuery();
					newEmployee.Id = (int)cmd.Parameters["@ID"].Value;
				}
				return newEmployee;
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

		public Employee GetEmployee(decimal employeeId)
		{
			SqlConnection connection = null;

			try
			{
				connection = new SqlConnection(_connectionString);
				connection.Open();
				using (var command = connection.CreateCommand())
				{
					command.CommandText = "select ID, FirstName, SurName, Patronymic, DateOfBirth, DocSeries, DocNumber, Position, DepartmentID from Empoyee where ID = @employeeId;";
					command.Parameters.AddWithValue("@employeeId", employeeId);
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							return new Employee
							{
								Id = reader.GetDecimal(reader.GetOrdinal("ID")),
								FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
								Surname = reader.GetString(reader.GetOrdinal("SurName")),
								Patronymic = reader.GetString(reader.GetOrdinal("Patronymic")),
								DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
								DocSeries = reader.GetString(reader.GetOrdinal("DocSeries")),
								DocNumber = reader.GetString(reader.GetOrdinal("DocNumber")),
								Position = reader.GetString(reader.GetOrdinal("Position")),
								DepartmentId = reader.GetGuid(reader.GetOrdinal("DepartmentID"))
							};
						}
					}
					throw new ArgumentException($"{nameof(Employee)} with id {employeeId} not found");
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

		public void DeleteEmployee(decimal employeeId)
		{
			SqlConnection connection = null;
			try
			{
				connection = new SqlConnection(_connectionString);
				connection.Open();
				using (var cmd = connection.CreateCommand())
				{
					cmd.CommandText = "delete from Empoyee where ID = @employeeId";
					cmd.Parameters.AddWithValue("@employeeId", employeeId);
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

		public void UpdateEmployee(Employee employee)
		{
			SqlConnection connection = null;
			try
			{
				connection = new SqlConnection(_connectionString);
				connection.Open();
				using (var cmd = connection.CreateCommand())
				{
					cmd.CommandText = "update Empoyee set FirstName = @FirstName, SurName = @SurName, Patronymic = @Patronymic, DateOfBirth = @DateOfBirth, DocSeries = @DocSeries, DocNumber = @DocNumber, Position = @Position, DepartmentID = @DepartmentID from Empoyee where ID = @employeeId;";
					cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
					cmd.Parameters.AddWithValue("@SurName", employee.Surname);
					cmd.Parameters.AddWithValue("@Patronymic", employee.Patronymic);
					cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth);
					cmd.Parameters.AddWithValue("@DocSeries", employee.DocSeries);
					cmd.Parameters.AddWithValue("@DocNumber", employee.DocNumber);
					cmd.Parameters.AddWithValue("@Position", employee.Position);
					cmd.Parameters.AddWithValue("@DepartmentID", employee.DepartmentId);
					cmd.Parameters.AddWithValue("@employeeId", employee.Id);
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