using System;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warehouse.Model;

namespace Warehouse.UnitTests {
    [TestClass]
    public class ProductTest {

        private Product product;
        private IDataSource dataSource;

        [TestInitialize]
        public void TestInitialize() {
            dataSource = new TestDataSource();
            product = dataSource.GetProducts()[1];
        }

        [TestMethod]
        public void Product_SetName() {
            // Act
            const string newProductName = "Synergistic Granite Lamp";
            product.SetName(newProductName);
            // Assert
            Assert.AreEqual(product.GetName(), newProductName);
        }

        [TestMethod]
        public void Product_SetWeight() {
            // Act
            const double newProductWeight = 0.15;
            product.SetWeight(newProductWeight);
            // Assert
            Assert.AreEqual(product.GetWeight(), newProductWeight);
        }

        [TestMethod]
        public void Product_SetNegativeWeight() {
            // Act
            const double newProductWeight = -0.5;
            product.SetWeight(newProductWeight);
            // Assert
            Assert.AreNotEqual(product.GetWeight(), newProductWeight);
        }

        [TestMethod]
        public void Product_SetProductCopies() {
            // Arrange
            ObservableCollection<ProductCopy> copies = dataSource.GetProductCopies();
            int copiesBefore = product.GetProductCopies().Count;
            copies.Add(new ProductCopy(product, "Product copy description", 0.5, 1));
            // Act
            product.SetProductCopies(copies);
            // Assert
            Assert.AreEqual(copiesBefore, 1);
            Assert.AreEqual(product.GetProductCopies().Count, 2);
        }

        [TestMethod]
        public void Product_AddAndRemoveProductCopy() {
            // Arrange
            ProductCopy productCopy = dataSource.GetProductCopies()[0];
            int copiesBefore = product.GetProductCopies().Count;
            // Act
            product.AddProductCopy(productCopy);
            // Assert
            Assert.AreEqual(copiesBefore, 1);
            Assert.AreEqual(product.GetProductCopies().Count, 2);
        }
    }
}
