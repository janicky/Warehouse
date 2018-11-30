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
    }
}
