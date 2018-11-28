using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.UnitTests {
    [TestClass]
    public class ProductCopyTests {

        private ProductCopy productCopy;
        private double price = 62.0;
        private string description = "Short product description";

        [TestInitialize]
        public void TestInitialize() {
            Product product = new Product("Product name", 10.0);
            productCopy = new ProductCopy(product, description, price, 1);
        }
        [TestMethod]
        public void CreateInstance_TestMethods() {
            // Arrange
            // ...

            // Assert
            Assert.AreEqual(productCopy.getDescription(), description);
            Assert.AreEqual(productCopy.getPrice(), price);
            Assert.AreEqual(productCopy.getCount(), 1);
        }
    }
}
