﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warehouse.Model;

namespace Warehouse.UnitTests.DataRepositoryTests {
    [TestClass]
    public class ProductCopiesRepositoryTest {
        private DataRepository dataRepository;

        [TestInitialize]
        public void TestInitialize() {
            ProductCopy.ResetIndex();
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
        public void DataRepositoryProductCopies_GetAllproductCopies() {
            //Assert
            Assert.AreEqual(dataRepository.GetAllProductCopies().Count, 1);
        }

        [TestMethod]
        public void DataRepositoryProductCopies_AddAndDeleteProductCopies() {
            try {
                //Arrange
                ProductCopy productCopy = new ProductCopy(dataRepository.GetProductByIndex(1), "Heavy Duty Linen Plate", 7.8, 1);
                //Act
                dataRepository.AddProductCopy(productCopy);
                ProductCopy firstCheck = dataRepository.GetProductCopyById(1);
                dataRepository.DeleteProductCopy(productCopy);
                ProductCopy secondCheck = dataRepository.GetProductCopyById(1);
                //Assert
                Assert.AreEqual(firstCheck, productCopy);
                Assert.IsNull(secondCheck);
            }
            catch {
                //Assert
                Assert.Fail();
            }
        }

        [TestMethod]
        public void DataRepositoryProductCopies_UpdateProductCopy() {
            //Arrange
            ProductCopy productCopy = new ProductCopy(
                id: 0,
                product: dataRepository.GetProductByIndex(1),
                description: "Granit",
                price: 12.0,
                count: 1
            );
            //Act
            dataRepository.UpdateProductCopy(productCopy);
            //Assert
            Assert.AreEqual(dataRepository.GetProductCopyByIndex(0), productCopy);

        }

    }
}
