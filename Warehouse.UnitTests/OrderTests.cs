using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.UnitTests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var employee = new Employee("Franek", "Janicky");
            var product = new Product("Konserwa", 100);
            var productCopy = new ProductCopy(product, "Opis zamowienia", 5, 1);
            var order = new Order(employee, productCopy, 10, 2);

            //Assert
            Assert.AreEqual(order.GetPrice(), 10);
            Assert.AreEqual(order.GetCount(), 2);


        }
    }
}
