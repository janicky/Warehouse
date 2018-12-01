using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse {
    public partial class DataService {
        public void DisplayProducts(Dictionary<int, Product> products) {
            foreach (Product product in products.Values) {
                Console.WriteLine(product);
            }
        }

        public Product FindProduct(Func<Product, bool> condition) {
            return repository.GetAllProducts().Values.First(condition);
        }

        public Product AddProduct(int index, string name, double weight) {
            Product product = new Product(name, weight);
            repository.AddProduct(index, product);
            return product;
        }

        public void UpdateProduct(Product product) {
            repository.UpdateProduct(product);
        }

        public bool DeleteProduct(Func<Product, bool> condition) {
            try {
                Product product = FindProduct(condition);
                return repository.DeleteProduct(product);
            } catch (Exception) {
                return false;
            }
        }
    }
}
