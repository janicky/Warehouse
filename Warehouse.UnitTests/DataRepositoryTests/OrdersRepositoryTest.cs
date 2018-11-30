using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.UnitTests.DataRepositoryTests {
    [TestClass]
    public class OrdersRepositoryTest {
        private DataRepository dataRepository;

        [TestInitialize]
        public void TestInitialize() {
            dataRepository = new DataRepository(new TestDataSource());
        }

        [TestMethod]
        public void DataRepositoryOrders_ItemsExists() {
            //Assert
            Assert.AreEqual(dataRepository.GetAllOrders().Count, 1);
        }

        [TestMethod]
        public void DataRepositoryOrders_GetElementByIndex() {
            Order order = dataRepository.GetOrderByIndex(0);
            //Assert
            Assert.AreEqual(order.GetPrice(), 12);
            Assert.AreEqual(order.GetCount(), 1);
        }

        [TestMethod]
        public void DataRepositoryOrders_UpdateOrder() {
            //Arrange
            Employee employee = new Employee(id: 0, firstName: "Anakin", lastName: "Calrissian");
            Product product = new Product("Product name", 10.0);
            ProductCopy productCopy = new ProductCopy(product, "description", 12, 1);
            Order order = new Order(employee, productCopy, 12.0, 1);
            //Act
            dataRepository.UpdateOrder(0 ,order);
            //Assert
            Assert.AreEqual(order, dataRepository.GetOrderByIndex(0));
        }
    }
}
