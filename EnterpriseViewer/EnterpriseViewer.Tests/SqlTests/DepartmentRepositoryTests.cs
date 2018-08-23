using System;
using System.Collections.Generic;
using System.Linq;
using EnterpriseViewer.Model;
using NUnit.Framework;

namespace EnterpriseViewer.Tests.SqlTests
{
	[TestFixture]
	public class DepartmentRepositoryTests : BaseSqlTests
	{
		[Test]
		public void ShouldAddDepartment()
		{
			//act
			var newDepartment = CreateTestDepartment();
			//arrange
			var addedDepartment = DepartmentsRepository.AddDepartment(newDepartment);
			AddDepartmentForClean(addedDepartment.Id);
			//asserts
			DepartmentsHaveTheSameFields(newDepartment, addedDepartment);
		}

		[Test]
		public void ShouldGetDepartment()
		{
			//arrange
			var department = CreateTestDepartment();
			var addedDepartment = DepartmentsRepository.AddDepartment(department);
			AddDepartmentForClean(addedDepartment.Id);
			var wantedDepartmentId = addedDepartment.Id;
			//act
			var foundedDepartment = DepartmentsRepository.GetDepartment(wantedDepartmentId);
			//asserts
			DepartmentsHaveTheSameFields(department, foundedDepartment);
			Assert.AreEqual(wantedDepartmentId, foundedDepartment.Id);
		}

		[Test]
		public void ShouldUpdateDepartment()
		{
			//arrange
			var department = CreateTestDepartment();
			var addedDepartment = DepartmentsRepository.AddDepartment(department);
			AddDepartmentForClean(addedDepartment.Id);
			var originalDepartmentFromDb = DepartmentsRepository.GetDepartment(addedDepartment.Id);
			UpdateTestDepartment(addedDepartment);
			//act
			DepartmentsRepository.UpdateDepartment(addedDepartment);
			var updatedDepartmentFromDb = DepartmentsRepository.GetDepartment(addedDepartment.Id);
			//asserts
			DepartmentsHaveTheDifferentFields(originalDepartmentFromDb, updatedDepartmentFromDb);
			Assert.AreEqual(originalDepartmentFromDb.Id, updatedDepartmentFromDb.Id);
		}

		[Test]
		public void ShouldDeleteDepartment()
		{
			//arrange
			var department = CreateTestDepartment();
			var addedDepartment = DepartmentsRepository.AddDepartment(department);
			//act
			DepartmentsRepository.DeleteDepartment(department.Id);
			//asserts
			Assert.Throws<ArgumentException>(() => { DepartmentsRepository.GetDepartment(addedDepartment.Id); });
		}

		[Test]
		public void ShouldAddDepartmentsAndGetThem()
		{
			//arrange
			var departmentsList = new List<Department>();
			for (int i = 0; i < 10; i++)
			{
				var department = CreateTestDepartment();
				var addedDepartment = DepartmentsRepository.AddDepartment(department);
				departmentsList.Add(addedDepartment);
				AddDepartmentForClean(addedDepartment.Id);
			}
			//act
			var departments = DepartmentsRepository.GetAllDepartments().ToList();
			//asserts
			departmentsList.ForEach(dep => Assert.True(departments.Any(d => d.Id == dep.Id)));
			Assert.True(departments.Count >= 10);
		}

		private static void DepartmentsHaveTheDifferentFields(Department firstDepartment, Department secondDepartment)
		{
			Assert.AreNotEqual(firstDepartment.Code, secondDepartment.Code);
			Assert.AreNotEqual(firstDepartment.Name, secondDepartment.Name);
			Assert.AreNotEqual(firstDepartment.ParentId, secondDepartment.ParentId);
		}

		private static void DepartmentsHaveTheSameFields(Department firstDepartment, Department secondDepartment)
		{
			Assert.AreEqual(firstDepartment.Code, secondDepartment.Code);
			Assert.AreEqual(firstDepartment.Name, secondDepartment.Name);
			Assert.AreEqual(firstDepartment.ParentId, secondDepartment.ParentId);
		}

		private static void UpdateTestDepartment(Department testDepatrment)
		{
			testDepatrment.Name = "NewName";
			testDepatrment.Code = "NewCode";
			testDepatrment.ParentId = new Guid("c17ac66a-88a5-462f-83ac-c447de599838");
		}

		private static Department CreateTestDepartment()
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