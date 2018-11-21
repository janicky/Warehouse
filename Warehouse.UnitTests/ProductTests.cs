using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.UnitTests {
    [TestClass]
    public class ProductTests {
        [TestMethod]
        public void TestMethod1() {
            // Arrange
            var product = new Product("test", 1.2);
        }
    }
}
