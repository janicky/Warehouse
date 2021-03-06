﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Model;

namespace Warehouse {
    public partial class DataService {

        public void DisplayProductCopies(IEnumerable<ProductCopy> productCopies) {
            foreach (ProductCopy productCopy in productCopies) {
                Console.WriteLine(productCopy);
            }
        }

        public ProductCopy FindProductCopy(Func<ProductCopy, bool> condition) {
            return repository.GetAllProductCopies().First(condition);
        }

        public ProductCopy AddProductCopy(Product product, string description, double price, int count) {
            ProductCopy productCopy = new ProductCopy(product, description, price, count);
            repository.AddProductCopy(productCopy);
            return productCopy;
        }

        public void UpdateProductCopy(ProductCopy productCopy) {
            repository.UpdateProductCopy(productCopy);
        }

        public bool DeleteProductCopy(Func<ProductCopy, bool> condition) {
            try {
                ProductCopy productCopy = FindProductCopy(condition);
                return repository.DeleteProductCopy(productCopy);
            } catch (Exception) {
                return false;
            }
        }

    }
}
