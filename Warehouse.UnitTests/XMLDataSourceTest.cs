using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warehouse.Model;
using Warehouse.DataSources;

namespace Warehouse.UnitTests {
    [TestClass]
    public class XMLDataSourceTest {

        IDataSource dataSource;

        [TestInitialize]
        public void TestInitialize() {
            Employee.ResetIndex();
            Product.ResetIndex();
            ProductCopy.ResetIndex();
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

        [TestMethod]
        public void ProductCopiesDeserialization() {
            // Arrange
            ObservableCollection<ProductCopy> productCopies = dataSource.GetProductCopies();
            ProductCopy productCopy = new ProductCopy(
                id: 0,
                product: dataSource.GetProducts()[2],
                description: "That's it! You people have stood in my way long enough. I'm going to clown college!",
                price: 12.02,
                count: 1
            );
            // Assert
            Assert.AreEqual(30, productCopies.Count);
            Assert.AreEqual(productCopy, productCopies[0]);
        }
    }
}
