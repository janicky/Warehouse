using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warehouse.Model;

namespace Warehouse.UnitTests.DataRepositoryTests {
    [TestClass]
    public class ProductsRepositoryTest {
        private DataRepository dataRepository;

        [TestInitialize]
        public void TestInitialize() {
            Product.ResetIndex();
            dataRepository = new DataRepository(new TestDataSource());
        }

        [TestMethod]
        public void DataRepositoryProducts_ItemsExists() {
            //Assert
            Assert.AreEqual(dataRepository.GetAllProducts().Count, 3);
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
            Product clock = new Product("Rustic Granite Knife", 1);
            //Act
            dataRepository.AddProduct(4, clock);
            Product firstCheck = dataRepository.GetProductByIndex(4);
            dataRepository.DeleteProduct(clock);
            Product secondCheck = dataRepository.GetProductByIndex(4);
            //Assert
            Assert.AreEqual(firstCheck, clock);
            Assert.IsNull(secondCheck);
        }
    }
}
