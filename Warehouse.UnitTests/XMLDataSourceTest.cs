using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.UnitTests {
    [TestClass]
    public class XMLDataSourceTest {
        [TestMethod]
        public void EmployeesDeserialization() {
            IDataSource dataSource = new XMLDataSource();
            List<Employee> employees = dataSource.GetEmployees();
            Assert.AreEqual(employees.Count, 20);
        }
    }
}
