using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse {
    public partial class DataRepository {
        //CRUD methods for Products in this partial class
        public void AddProduct(int index, Product product) {
            dataContext.products.Add(index, product);
        }

        public Product GetProductByIndex(int index) {
            try {
                return dataContext.products[index];
            } catch(Exception) {
                return null;
            }
        }

        public Product GetProductById(int id) {
            try {
                return dataContext.products.Values.First(p => p.GetId() == id);
            } catch (Exception) {
                return null;
            }
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
                var deletingProduct = dataContext.products.First(p => p.Value.GetId() == product.GetId());
                bool deleted = dataContext.products.Remove(deletingProduct.Key);
                if (!deleted) throw new Exception();
            }
            catch {
                throw new NotImplementedException();
            }
        }

    }
}
