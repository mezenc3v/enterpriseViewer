using System;
using System.Collections.Generic;
using EnterpriseViewer.Model;
using NLog;

namespace EnterpriseViewer.Data.Sql
{
	public class DepartmentRepository : IDepartmentRepository
	{
		internal static ILogger Logger = LogManager.GetCurrentClassLogger();
		private readonly AdoNetContext _context;
		public DepartmentRepository(AdoNetContext context)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context));
		}

		public IEnumerable<Department> GetAllDepartments()
		{
			var departmentIds = new List<Guid>();
			var result = new List<Department>();
			try
			{
				using (var command = _context.CreateCommand())
				{
					command.CommandText = "select ID from Department";
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							var departmentId = reader.GetGuid(reader.GetOrdinal("ID"));
							departmentIds.Add(departmentId);
						}
					}
				}

				foreach (var departmentId in departmentIds)
				{
					var department = GetDepartment(departmentId);
					result.Add(department);
				}

				return result;
			}
			catch (Exception e)
			{
				Logger.Error(e);
				throw;
			}
		}

		public Department AddDepartment(Department department)
		{
			try
			{
				var newDepartment = new Department
				{
					Id = department.Id,
					Name = department.Name,
					Code = department.Code,
					ParentId = department.ParentId
				};

				using (var cmd = _context.CreateCommand())
				{
					cmd.CommandText = @"insert into Department values (@ID,@Name,@Code,@ParentDepartmentID);";
					cmd.Parameters.AddWithValue("@ID", newDepartment.Id);
					cmd.Parameters.AddWithValue("@Name", newDepartment.Name);
					cmd.Parameters.AddWithNullValue("@Code", newDepartment.Code);
					cmd.Parameters.AddWithNullValue("@ParentDepartmentID", newDepartment.ParentId);
					cmd.ExecuteNonQuery();
				}
				return newDepartment;
			}
			catch (Exception e)
			{
				Logger.Error(e);
				throw;
			}
		}

		public Department GetDepartment(Guid departmentId)
		{
			try
			{
				using (var command = _context.CreateCommand())
				{
					command.CommandText = "select ID, Name, Code, ParentDepartmentID from Department where ID = @departmentId;";
					command.Parameters.AddWithValue("@departmentId", departmentId);
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							var newDep = new Department
							{
								Id = reader.GetGuid(reader.GetOrdinal("ID")),
								Name = reader[reader.GetOrdinal("Name")] as string,
								Code = reader[reader.GetOrdinal("Code")] as string,
								ParentId = reader["ParentDepartmentID"] as Guid?
							};
							return newDep;
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
		}

		public void DeleteDepartment(Guid departmentId)
		{
			try
			{
				using (var cmd = _context.CreateCommand())
				{
					const string cteCommand = @"WITH RowsToDelete AS (
													select ID
													from Department
													where ID = @departmentId
													union all
													select ch.ID
													from Department ch inner join RowsToDelete p
													on p.ID = ch.ParentDepartmentID)";
					cmd.CommandText += cteCommand;
					cmd.CommandText += @"delete from Empoyee where DepartmentID in (select ID from RowsToDelete);";
					cmd.CommandText += cteCommand;
					cmd.CommandText += "delete from Department where ID in (select ID from RowsToDelete);";
					cmd.Parameters.AddWithValue("@departmentId", departmentId);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception e)
			{
				Logger.Error(e);
				throw;
			}
		}

		public void UpdateDepartment(Department department)
		{
			try
			{
				using (var cmd = _context.CreateCommand())
				{
					cmd.CommandText = "update Department set Name = @Name, Code = @Code, ParentDepartmentID = @ParentDepartmentID from Department where ID = @departmentId;";
					cmd.Parameters.AddWithValue("@Name", department.Name);
					cmd.Parameters.AddWithNullValue("@Code", department.Code);
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
		}
	}
}