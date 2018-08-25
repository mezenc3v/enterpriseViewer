using System;
using System.Configuration;
using EnterpriseViewer.Data;
using EnterpriseViewer.Data.Sql;
using EnterpriseViewer.Model;
using NLog;
using NUnit.Framework;

namespace EnterpriseViewer.Tests.SqlTests
{
	[TestFixture]
	public class BaseSqlTests
	{
		protected readonly IUnitOfWork UnitOfWork;
		internal static ILogger Logger = LogManager.GetCurrentClassLogger();

		public BaseSqlTests() : this(ConfigurationManager.ConnectionStrings["TestDb"].ConnectionString)
		{
		}
		public BaseSqlTests(string connectionString)
		{
			UnitOfWork = new SqlUnitOfWork(connectionString);
		}

		[OneTimeSetUp]
		public void Init()
		{
		}

		[OneTimeTearDown]
		public void Clean()
		{
			UnitOfWork.Dispose();
		}

		public Employee CreateEmployee()
		{
			return new Employee
			{
				FirstName = "TestFirstName",
				Surname = "TestSurName",
				Patronymic = "TestPatrName",
				DateOfBirth = new DateTime(1994, 10, 31),
				DepartmentId = new Guid("6453b876-8b5f-48a7-b088-f526eb592752"),
				DocNumber = "123",
				DocSeries = "456",
				Position = "TestPos"
			};
		}

		public Department CreateDepartment()
		{
			return new Department
			{
				Id = Guid.NewGuid(),
				Name = "TestName",
				Code = "TestCode",
				ParentId = new Guid("6453b876-8b5f-48a7-b088-f526eb592752"),
			};
		}
	}
}