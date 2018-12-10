using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.UnitTests {
    class RandomDataSource : IDataSource {

        private List<Employee> employees = new List<Employee>();
        private Dictionary<int, Product> products = new Dictionary<int, Product>();
        private ObservableCollection<ProductCopy> productCopies = new ObservableCollection<ProductCopy>();
        private ObservableCollection<Order> orders = new ObservableCollection<Order>();

        public RandomDataSource() {

        }

        // Getters
        public List<Employee> GetEmployees() {
            return employees;
        }

        public Dictionary<int, Product> GetProducts() {
            return products;
        }

        public ObservableCollection<ProductCopy> GetProductCopies() {
            return productCopies;
        }

        public ObservableCollection<Order> GetOrders() {
            return orders;
        }

    }
}
