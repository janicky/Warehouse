using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.UnitTests.DataRepositoryTests {
    [TestClass]
    class ProductsRepositoryTest {
        private DataRepository dataRepository;

        [TestInitialize]
        public void TestInitialize() {
            dataRepository = new DataRepository(new TestDataSource());
        }

        [TestMethod]
        public void DataRepositoryEmployees_ItemsExists() {
            //Assert
            Assert.AreEqual(dataRepository.GetAllProducts().Count, 1);
        }

        [TestMethod]
        public void DataRepositoryProducts_GetElemmentByIndex() {
            //Assert
            Product product = dataRepository.GetProductByIndex(0);
            Assert.AreEqual(product.GetName(), "Monitor");
            Assert.AreEqual(product.GetWeight(), 4.5);
        }

        [TestMethod]
        public void DataRepositoryProducts_GetElementById() {
            //Assert
            Product product = dataRepository.GetProductById(0);
            Assert.AreEqual(product.GetName(), "Monitor");
            Assert.AreEqual(product.GetWeight(), 4.5);
        }

        
    }
}