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

        [TestMethod]
        public void DataRepositoryProducts_UpdateElements() {
            //Arrange
            Product product = new Product(id: 0, name: "Drukarka", weight: 5);
            //Act
            dataRepository.UpdateProduct(product);
            //Assert
            Assert.AreEqual(product, dataRepository.GetProductById(0));
        }

        [TestMethod]
        public void DataRepositoryProducts_AddAndDeleteElements() {
            //Arrenge
            Product Clock = new Product("Zegar", 1);
            //Act
            dataRepository.AddProduct(Clock);
            Product firstCheck = dataRepository.GetProductByID(1);
            dataRepository.DeleteProduct(Clock);
            Product secondCheck = dataRepository.GetProductById(1);
            //Assert
            Assert.AreEqual(firstCheck, Clock);
            Assert.IsNull(secondCheck);
        }
    }
}