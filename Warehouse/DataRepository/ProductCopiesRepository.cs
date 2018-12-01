using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse {
    public partial class DataRepository {
        // CRUD methods for ProductCopies in this partial class
        public void AddProductCopy(ProductCopy productCopy) {
            dataContext.productCopies.Add(productCopy);
        }

        public ProductCopy GetProductCopyByIndex(int index) {
            try {
                return dataContext.productCopies.ElementAt(index);
            }
            catch (Exception) {
               return null;
            }
        }

        public ProductCopy GetProductCopyById(int id) {
            try {
                return dataContext.productCopies.First(e => e.GetId() == id);
            }
            catch (Exception) {
                return null;
            }
        }

        public ObservableCollection<ProductCopy> GetAllProductCopies() {
            return dataContext.productCopies;
        }

        public void UpdateProductCopy(ProductCopy productCopy) {
            ProductCopy updatingCopy = GetProductCopyById(productCopy.GetId());
            if (updatingCopy != null) {
                updatingCopy.SetProduct(productCopy.GetProduct());
                updatingCopy.SetDescription(productCopy.GetDescription());
                updatingCopy.SetPrice(productCopy.GetPrice());
                updatingCopy.SetCount(productCopy.GetCount());
            }
        }

        public bool DeleteProductCopy(ProductCopy productCopy) {
            try {
                return dataContext.productCopies.Remove(productCopy);
            }
            catch (Exception) {
                return false;
            }
        }
    }
}
