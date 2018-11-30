using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.UnitTests.DataRepositoryTests {
    [TestClass]
    public class ProductsRepositoryTest {
        private DataRepository dataRepository;

        [TestInitialize]
        public void TestInitialize() {
            dataRepository = new DataRepository(new TestDataSource());
        }

        [TestMethod]
        public void DataRepositoryProducts_ItemsExists() {
            //Assert
            Assert.AreEqual(dataRepository.GetAllProducts().Count, 1);
        }

        [TestMethod]
        public void DataRepositoryProducts_GetElementByIndex() {
            //Assert
            Product product = dataRepository.GetProductByIndex(1);
            Assert.AreEqual(product.GetName(), "Synergistic Bronze Watch");
            Assert.AreEqual(product.GetWeight(), 0.1);
        }

        [TestMethod]
        public void DataRepositoryProducts_GetElementById() {
            //Assert
            Product product = dataRepository.GetProductById(0);
            Assert.AreEqual(product.GetName(), "Synergistic Bronze Watch");
            Assert.AreEqual(product.GetWeight(), 0.1);
        }

        [TestMethod]
        public void DataRepositoryProducts_UpdateElement() {
            //Arrange
            Product product = new Product(id: 0, name: "Awesome Concrete Watch", weight: 5);
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
            dataRepository.AddProduct(1, Clock);
            Product firstCheck = dataRepository.GetProductById(1);
            dataRepository.DeleteProduct(Clock);
            Product secondCheck = dataRepository.GetProductById(1);
            //Assert
            Assert.AreEqual(firstCheck, Clock);
            Assert.IsNull(secondCheck);
        }
    }
}
