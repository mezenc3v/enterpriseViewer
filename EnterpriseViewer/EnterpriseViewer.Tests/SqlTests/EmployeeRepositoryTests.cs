using System;
using System.Collections.Generic;
using System.Linq;
using EnterpriseViewer.Model;
using NUnit.Framework;

namespace EnterpriseViewer.Tests.SqlTests
{
	[TestFixture]
	public class EmployeeRepositoryTests : BaseSqlTests
	{
		[Test]
		public void ShouldAddNewEmployee()
		{
			//arrange
			var newEmployee = CreateEmployee();
			//act
			var addedEmp = UnitOfWork.EmployeeRepository.AddEmployee(newEmployee);
			//assert
			EmployeesHaveTheSameFields(newEmployee, addedEmp);
		}

		[Test]
		public void ShouldGetEmployee()
		{
			//arrange
			var employee = CreateEmployee();
			var addedEmployee = UnitOfWork.EmployeeRepository.AddEmployee(employee);
			var wantedEmployeeId = addedEmployee.Id;
			//act
			var foundedEmployee = UnitOfWork.EmployeeRepository.GetEmployee(wantedEmployeeId);
			//asserts
			EmployeesHaveTheSameFields(employee, foundedEmployee);
			Assert.AreEqual(wantedEmployeeId, foundedEmployee.Id);
		}

		[Test]
		public void ShouldUpdateEmployee()
		{
			//arrange
			var employee = CreateEmployee();
			var addedEmployee = UnitOfWork.EmployeeRepository.AddEmployee(employee);
			var originalEmployeeFromDb = UnitOfWork.EmployeeRepository.GetEmployee(addedEmployee.Id);
			UpdateTestEmployee(addedEmployee);
			//act
			UnitOfWork.EmployeeRepository.UpdateEmployee(addedEmployee);
			var updatedEmployeeFromDb = UnitOfWork.EmployeeRepository.GetEmployee(addedEmployee.Id);
			//asserts
			EmployeesHaveTheDifferentFields(originalEmployeeFromDb, updatedEmployeeFromDb);
			Assert.AreEqual(originalEmployeeFromDb.Id, updatedEmployeeFromDb.Id);
		}

		[Test]
		public void ShouldDeleteEmployee()
		{
			//arrange
			var employee = CreateEmployee();
			var addedEmployee = UnitOfWork.EmployeeRepository.AddEmployee(employee);
			//act
			UnitOfWork.EmployeeRepository.DeleteEmployee(addedEmployee.Id);
			//asserts
			Assert.Throws<ArgumentException>(() => { UnitOfWork.EmployeeRepository.GetEmployee(addedEmployee.Id); });
		}

		[Test]
		public void ShouldGetEmloyeesFromDepartment()
		{
			//arrange
			var depId = new Guid("6453b876-8b5f-48a7-b088-f526eb592752");
			var employeesList = new List<Employee>();
			for (int i = 0; i < 10; i++)
			{
				var emp = CreateEmployee();
				var addedEmployee = UnitOfWork.EmployeeRepository.AddEmployee(emp);
				addedEmployee.DepartmentId = depId;
				employeesList.Add(addedEmployee);
			}
			//act
			var employeesFromDb = UnitOfWork.EmployeeRepository.GetEmployeesFromDepartment(depId).ToList();
			//asserts
			employeesList.ForEach(employee => Assert.True(employeesFromDb.Any(e => e.Id == employee.Id)));
			Assert.True(employeesFromDb.Count >= 10);
		}

		private static void EmployeesHaveTheDifferentFields(Employee firstEmployee, Employee secondEmployee)
		{
			Assert.AreNotEqual(firstEmployee.DocNumber, secondEmployee.DocNumber);
			Assert.AreNotEqual(firstEmployee.FirstName, secondEmployee.FirstName);
			Assert.AreNotEqual(firstEmployee.Patronymic, secondEmployee.Patronymic);
			Assert.AreNotEqual(firstEmployee.DateOfBirth, secondEmployee.DateOfBirth);
			Assert.AreNotEqual(firstEmployee.DepartmentId, secondEmployee.DepartmentId);
			Assert.AreNotEqual(firstEmployee.DocSeries, secondEmployee.DocSeries);
			Assert.AreNotEqual(firstEmployee.Position, secondEmployee.Position);
		}

		private static void EmployeesHaveTheSameFields(Employee firstEmployee, Employee secondEmployee)
		{
			Assert.AreEqual(firstEmployee.DocNumber, secondEmployee.DocNumber);
			Assert.AreEqual(firstEmployee.FirstName, secondEmployee.FirstName);
			Assert.AreEqual(firstEmployee.Patronymic, secondEmployee.Patronymic);
			Assert.AreEqual(firstEmployee.DateOfBirth, secondEmployee.DateOfBirth);
			Assert.AreEqual(firstEmployee.DepartmentId, secondEmployee.DepartmentId);
			Assert.AreEqual(firstEmployee.DocSeries, secondEmployee.DocSeries);
			Assert.AreEqual(firstEmployee.Position, secondEmployee.Position);
		}

		private static void UpdateTestEmployee(Employee testEmployee)
		{
			testEmployee.FirstName = "NewFirstName";
			testEmployee.Surname = "NewSurname";
			testEmployee.Patronymic = "NewPatronymice";
			testEmployee.DocNumber = "NewDoc";
			testEmployee.DateOfBirth = DateTime.Now;
			testEmployee.DocSeries = "NewD";
			testEmployee.Position = "NewPosition";
			testEmployee.DepartmentId = new Guid("c17ac66a-88a5-462f-83ac-c447de599838");
		}
	}
}