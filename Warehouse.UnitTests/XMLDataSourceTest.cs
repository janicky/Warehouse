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

            Employee employee = new Employee(id: 0, firstName: "Ahsoka", lastName: "Tano");
            Assert.AreEqual(employee, employees[0]);
        }

        [TestMethod]
        public void ProductsDeserialization() {
            // Arrange
            Dictionary<int, Product> products = dataSource.GetProducts();
            Product product = new Product(id: 0, name: "Mother Night", weight: 23.08);
            // Assert
            Assert.AreEqual(products.Count, 30);
            Assert.AreEqual(product, products[1]);
        }
    }
}
