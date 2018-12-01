using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

namespace Warehouse {
    public partial class DataService {

        private DataRepository repository;

        public DataService(DataRepository repository) {
            this.repository = repository;
        }

        public void DisplayProducts(IEnumerable<Product> products) {
            foreach (Product product in products) {
                Console.WriteLine(product);
                foreach (ProductCopy productCopy in product.GetProductCopies()) {
                    Console.WriteLine(productCopy);
                }
            }
        }

        public Dictionary<int, Product> GetAllProducts() {
            return repository.GetAllProducts();
        }

        public IEnumerable<Order> GetOrdersForEmployee(Employee employee) {
            return repository.GetAllOrders().Where(e => e.GetEmployee() == employee);
        }

        public IEnumerable<Order> GetOrdersBetweenDates(DateTimeOffset from, DateTimeOffset to) {
            return repository.GetAllOrders().Where(e => e.GetOrderDate() >= from && e.GetOrderDate() <= to);
        }

        public Order AddOrder(Employee employee, ProductCopy productCopy) {
            Order order = new Order(employee, productCopy);
            productCopy.SetOrder(order);
            repository.AddOrder(order);
            return order;
        }

    }
}