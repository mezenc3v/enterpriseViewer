using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using EnterpriseViewer.Data;
using EnterpriseViewer.Data.Sql;
using NLog;
using NUnit.Framework;

namespace EnterpriseViewer.Tests.SqlTests
{
	[TestFixture]
	public class BaseSqlTests
	{
		private static readonly List<Guid> DepartmentsForRemoval = new List<Guid>();
		private static readonly List<decimal> EmployeesForRemoval = new List<decimal>();

		private readonly string _connectionString;
		protected readonly IEmployeeRepository EmployeesRepository;
		protected readonly IDepartmentRepository DepartmentsRepository;
		internal static ILogger Logger = LogManager.GetCurrentClassLogger();

		public BaseSqlTests() : this(ConfigurationManager.ConnectionStrings["TestDb"].ConnectionString)
		{
		}
		public BaseSqlTests(string connectionString)
		{
			_connectionString = connectionString;
			EmployeesRepository = new EmployeeRepository(_connectionString);
			DepartmentsRepository = new DepartmentRepository(_connectionString);
		}

		[OneTimeSetUp]
		public void Init()
		{
		}

		[OneTimeTearDown]
		public void Clean()
		{
			CleanEmployees();
			CleanDepartments();
		}

		protected void AddEmployeeForClean(decimal employeeId)
		{
			EmployeesForRemoval.Add(employeeId);
		}

		protected void AddDepartmentForClean(Guid depatrmentId)
		{
			DepartmentsForRemoval.Add(depatrmentId);
		}

		private void CleanEmployees()
		{
			foreach (var employeeId in EmployeesForRemoval.Distinct())
			{
				try
				{
					EmployeesRepository.DeleteEmployee(employeeId);
				}
				catch (Exception e)
				{
					Logger.Trace(e, $"Cannot remove test employee with id {employeeId}");
				}
			}
		}

		private void CleanDepartments()
		{
			foreach (var departmentId in DepartmentsForRemoval.Distinct())
			{
				try
				{
					DepartmentsRepository.DeleteDepartment(departmentId);
				}
				catch (Exception e)
				{
					Logger.Trace(e, $"Cannot remove test department with id {departmentId}");
				}
			}
		}
	}
}