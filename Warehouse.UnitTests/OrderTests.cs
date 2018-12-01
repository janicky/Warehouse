using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.UnitTests
{
    [TestClass]
    public class OrderTests {
        private DataRepository dataRepository;
        private Order order;

        [TestInitialize]
        public void TestInitialize() {
            Order.ResetIndex();
            dataRepository = new DataRepository(new TestDataSource());
            order = dataRepository.GetAllOrders()[0];
        }

        [TestMethod]
        public void Order_NegativeAndNullPrice() {
            double[] prices = { 1, 0, -0.5, -0.0000001 };

            foreach (double price in prices) {
                order.SetPrice(price);
                Assert.IsTrue(order.GetPrice() > 0);
            }
        }
    }
}
