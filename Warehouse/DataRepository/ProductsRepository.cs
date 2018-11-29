using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse {
    public partial class DataRepository {
        //CRUD methods for Products in this partial class
        public void AddProduct(int id, Product product) {
            dataContext.products.Add(id,product);
        }

        public Product GetProductByIndex(int index) {
            return dataContext.products[index];
        }

        public Product GetProductById(int id) {
            return dataContext.products.Values.First(p => p.GetId() == id);
        }

        public Dictionary<int, Product> GetAllProducts() {
            return dataContext.products;
        }

        public void UpdateProduct(Product product) {
            Product updatingProduct = GetProductById(product.GetId());
            if (updatingProduct != null) {
                updatingProduct.SetName(product.GetName());
                updatingProduct.SetWeight(product.GetWeight());
            }
        }

        public void DeleteProduct(Product product) {
            try {
                Product deletingProduct = GetProductById(product.GetId());
                //bool deleted = dataContext.products.Remove(deletingProduct);
                //if (!deleted) throw new Exception();
            }
            catch {
                throw new NotImplementedException();
            }
        }

    }
}
