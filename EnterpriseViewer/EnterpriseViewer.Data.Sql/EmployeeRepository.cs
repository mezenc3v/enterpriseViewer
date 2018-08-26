using System;
using System.Collections.Generic;
using System.Data;
using EnterpriseViewer.Model;
using NLog;

namespace EnterpriseViewer.Data.Sql
{
	public class EmployeeRepository : IEmployeeRepository
	{
		internal static ILogger Logger = LogManager.GetCurrentClassLogger();
		private readonly AdoNetContext _context;
		public EmployeeRepository(AdoNetContext context)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context));
		}

		public Employee AddEmployee(Employee employee)
		{
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

				using (var cmd = _context.CreateCommand())
				{
					cmd.CommandText = @"insert into Empoyee values (@FirstName,@SurName,@Patronymic,@DateOfBirth,@DocSeries,@DocNumber,@Position,@DepartmentID); SET @ID = SCOPE_IDENTITY()";
					cmd.Parameters.Add("@ID", SqlDbType.Int, 5).Direction = ParameterDirection.Output;
					cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
					cmd.Parameters.AddWithValue("@SurName", employee.Surname);
					cmd.Parameters.AddWithNullValue("@Patronymic", employee.Patronymic);
					cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth);
					cmd.Parameters.AddWithNullValue("@DocSeries", employee.DocSeries);
					cmd.Parameters.AddWithNullValue("@DocNumber", employee.DocNumber);
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
		}

		public Employee GetEmployee(decimal employeeId)
		{
			try
			{
				using (var command = _context.CreateCommand())
				{
					command.CommandText = "select ID, FirstName, SurName, Patronymic, DateOfBirth, DocSeries, DocNumber, Position, DepartmentID from Empoyee where ID = @employeeId;";
					command.Parameters.AddWithValue("@employeeId", employeeId);
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							var employee = new Employee
							{
								Id = reader.GetDecimal(reader.GetOrdinal("ID")),
								FirstName = reader[reader.GetOrdinal("FirstName")] as string,
								Surname = reader[reader.GetOrdinal("SurName")] as string,
								Patronymic = reader[reader.GetOrdinal("Patronymic")] as string,
								DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
								DocSeries = reader[reader.GetOrdinal("DocSeries")] as string,
								DocNumber = reader[reader.GetOrdinal("DocNumber")] as string,
								Position = reader[reader.GetOrdinal("Position")] as string,
								DepartmentId = reader.GetGuid(reader.GetOrdinal("DepartmentID"))
							};
							return employee;
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
		}

		public void DeleteEmployee(decimal employeeId)
		{
			try
			{
				using (var cmd = _context.CreateCommand())
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
		}

		public void UpdateEmployee(Employee employee)
		{
			try
			{
				using (var cmd = _context.CreateCommand())
				{
					cmd.CommandText = "update Empoyee set FirstName = @FirstName, SurName = @SurName, Patronymic = @Patronymic, DateOfBirth = @DateOfBirth, DocSeries = @DocSeries, DocNumber = @DocNumber, Position = @Position, DepartmentID = @DepartmentID from Empoyee where ID = @employeeId;";
					cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
					cmd.Parameters.AddWithValue("@SurName", employee.Surname);
					cmd.Parameters.AddWithNullValue("@Patronymic", employee.Patronymic);
					cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth);
					cmd.Parameters.AddWithNullValue("@DocSeries", employee.DocSeries);
					cmd.Parameters.AddWithNullValue("@DocNumber", employee.DocNumber);
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
		}

		public IEnumerable<Employee> GetEmployeesFromDepartment(Guid departmentId)
		{
			var employeeIds = new List<decimal>();
			var result = new List<Employee>();
			try
			{
				using (var cmd = _context.CreateCommand())
				{
					cmd.CommandText = "select ID from Empoyee where DepartmentID = @DepartmentID";
					cmd.Parameters.AddWithValue("@DepartmentID", departmentId);
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							var employeeId = reader.GetDecimal(reader.GetOrdinal("ID"));
							employeeIds.Add(employeeId);
						}
					}
				}

				foreach (var employeeId in employeeIds)
				{
					var employee = GetEmployee(employeeId);
					result.Add(employee);
				}
				return result;
			}
			catch (Exception e)
			{
				Logger.Error(e);
				throw;
			}
		}
	}
}