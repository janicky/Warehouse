using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.UnitTests
{
    [TestClass]
    public class OrderTests {
        private DataRepository dataRepository;

        [TestInitialize]
        public void TestInitialize() {
            Order.ResetIndex();
            dataRepository = new DataRepository(new TestDataSource());
        }

        [TestMethod]
        public void Order_Getters()
        {
            //Arrange
            Order order = dataRepository.GetOrderByIndex(0);
            //Assert
            Assert.AreEqual(order.GetEmployee(), dataRepository.GetEmployeeByIndex(0));
            Assert.AreEqual(order.GetProductCopy(), dataRepository.GetProductCopyById(0));
            Assert.AreEqual(order.GetPrice(), 12.0);
            Assert.AreEqual(order.GetCount(), 1);


        }
    }
}
