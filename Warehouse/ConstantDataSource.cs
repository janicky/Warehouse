using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class ConstantDataSource : IDataSource {
        public List<Employee> GetEmployees() {
            throw new NotImplementedException();
        }

        public ObservableCollection<Order> GetOrders() {
            throw new NotImplementedException();
        }

        public Dictionary<int, Product> GetProducts() {
            throw new NotImplementedException();
        }

        public ObservableCollection<ProductCopy> productCopies() {
            throw new NotImplementedException();
        }
    }
}
