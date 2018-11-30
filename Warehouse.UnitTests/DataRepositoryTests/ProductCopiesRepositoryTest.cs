using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.UnitTests.DataRepositoryTests {
    [TestClass]
    public class ProductCopiesRepositoryTest {
        private DataRepository dataRepository;

        [TestInitialize]
        public void TestInitialize() {
            dataRepository = new DataRepository(new TestDataSource());
        }

        [TestMethod]
        public void DataRepositoryProductCopies_GetProductCopyByIndex() {
            try {
                //Arrange
                ProductCopy productCopyFromDataSource = dataRepository.GetAllProductCopies()[0];
                ProductCopy productCopy = dataRepository.GetProductCopyByIndex(0);
                //Assert
                Assert.AreEqual(productCopy, productCopyFromDataSource);
            }
            catch {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void DataRepositoryProductCopies_GetProductCopyById() {
            //Arrenge
            ProductCopy productCopyFromDataSource = dataRepository.GetAllProductCopies()[0];
            ProductCopy productCopy = dataRepository.GetProductCopyByIndex(0);
            //Assert
            Assert.AreEqual(productCopy, productCopyFromDataSource);
        }
    }
}
