using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class ConstantDataSource : IDataSource {
        private List<Employee> employees = new List<Employee>();
        private Dictionary<int, Product> products = new Dictionary<int, Product>();
        public List<Employee> GetEmployees() {
            employees.Add(new Employee("Jan", "Kowalski"));
            return employees;
        }

        public Dictionary<int, Product> GetProducts() {
            products.Add(1, new Product("Monitor", 4.5));
            return products;
        }

        public ObservableCollection<Order> GetOrders() {
            throw new NotImplementedException();
        }

        public ObservableCollection<ProductCopy> productCopies() {
            throw new NotImplementedException();
        }
    }
}
