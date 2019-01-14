using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Warehouse.Model;

namespace Warehouse.UnitTests {
    [TestClass]
    public class ProductCopyTests {

        private ProductCopy productCopy;
        private DataRepository dataRepository;

        [TestInitialize]
        public void TestInitialize() {
            ProductCopy.ResetIndex();
            dataRepository = new DataRepository(new TestDataSource());
            productCopy = dataRepository.GetAllProductCopies()[0];
        }
        [TestMethod]
        public void ProductCopy_SetProduct() {
            // Arrange
            Product product = dataRepository.GetAllProducts()[1];
            Product newProduct = dataRepository.GetAllProducts()[2];
            // Act
            Product beforeSet = productCopy.GetProduct();
            productCopy.SetProduct(newProduct);
            // Assert
            Assert.AreEqual(beforeSet, product);
            Assert.AreEqual(productCopy.GetProduct(), newProduct);
        }
    }
}
