using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.UnitTests.DataRepositoryTests {
    [TestClass]
    public class EmployeesRepositoryTest {
        private DataRepository dataRepository;

        [TestInitialize]
        public void TestInitialize() {
            Employee.ResetIndex();
            dataRepository = new DataRepository(new TestDataSource());
        }

        [TestMethod]
        public void DataRepositoryEmployees_ItemsExists() {
            // Arrange
            DataRepository dataRepository = new DataRepository(new TestDataSource());
            // Assert
            Assert.AreEqual(dataRepository.GetAllEmployees().Count, 1);
        }

        [TestMethod]
        public void DataRepositoryEmployees_GetElementByIndex() {
            // Assert
            Employee employee = dataRepository.GetEmployeeByIndex(0);
            Assert.AreEqual(employee.GetFirstName(), "Anakin");
            Assert.AreEqual(employee.GetLastName(), "Skywalker");
            
        }

        [TestMethod]
        public void DataRepositoryEmployees_GetElementById() {
            // Arrange
            Employee employee = dataRepository.GetEmployeeById(0);
            // Assert
            Assert.AreEqual(employee.GetFirstName(), "Anakin");
            Assert.AreEqual(employee.GetLastName(), "Skywalker");
        }

        [TestMethod]
        public void DataRepositoryEmployees_UpdateElement() {
            // Arrange
            Employee employee = new Employee(id: 0, firstName: "Anakin", lastName: "Calrissian");
            // Act
            dataRepository.UpdateEmployee(employee);
            // Assert
            Assert.AreEqual(employee, dataRepository.GetEmployeeById(0));
        }

        [TestMethod]
        public void DataRepositoryEmployees_AddAndDeleteElement() {
            // Arrange
            Employee DarthSidious = new Employee("Darth", "Sidious");
            // Act
            dataRepository.AddEmployee(DarthSidious);
            Employee firstCheck = dataRepository.GetEmployeeById(1);
            dataRepository.DeleteEmployee(DarthSidious);
            Employee secondCheck = dataRepository.GetEmployeeById(1);
            // Assert
            Assert.AreEqual(firstCheck, DarthSidious);
            Assert.IsNull(secondCheck);
        }
    }
}
