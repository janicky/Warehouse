using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warehouse.Model;

namespace Warehouse.UnitTests.DataRepositoryTests {
    [TestClass]
    public class OrdersRepositoryTest {
        private DataRepository dataRepository;

        [TestInitialize]
        public void TestInitialize() {
            Order.ResetIndex();
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
            Order order = new Order(
                id: 0,
                employee: dataRepository.GetAllEmployees()[0], 
                productCopy: dataRepository.GetAllProductCopies()[0], 
                price: 12.0, 
                count: 1
            );
            //Act
            dataRepository.UpdateOrder(order);
            //Assert
            Assert.AreEqual(dataRepository.GetOrderByIndex(0), order);
        }

        [TestMethod]
        public void DataRepositoryOrders_AddAndDeleteOrders() {
            //Arrange
            Employee employee = new Employee(id: 0, firstName: "Anakin", lastName: "Calrissian");
            Product product = new Product("Product name", 10.0);
            ProductCopy productCopy = new ProductCopy(product, "description", 12, 1);
            Order order = new Order(employee, productCopy, 12.0, 1);
            //Act
            dataRepository.AddOrder(order);
            Order firstCheck = dataRepository.GetOrderByIndex(1);
            dataRepository.DeleteOrder(order);
            Order secondCheck = dataRepository.GetOrderByIndex(1);
            //Assert
            Assert.AreEqual(firstCheck, order);
            Assert.IsNull(secondCheck);
        }
    }
}
