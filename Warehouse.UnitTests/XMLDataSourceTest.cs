using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.UnitTests {
    [TestClass]
    public class XMLDataSourceTest {

        IDataSource dataSource;

        [TestInitialize]
        public void TestInitialize() {
            dataSource = new XMLDataSource();
        }

        [TestMethod]
        public void EmployeesDeserialization() {
            // Arrange
            List<Employee> employees = dataSource.GetEmployees();
            // Assert
            Assert.AreEqual(employees.Count, 20);
        }
    }
}
