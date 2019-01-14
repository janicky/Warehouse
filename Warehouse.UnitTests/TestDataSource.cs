using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using Warehouse.Model;

namespace Warehouse.UnitTests {
    class TestDataSource : IDataSource {
        private List<Employee> employees = new List<Employee>();
        private Dictionary<int, Product> products = new Dictionary<int, Product>();
        private ObservableCollection<ProductCopy> productCopies = new ObservableCollection<ProductCopy>();
        private ObservableCollection<Order> orders = new ObservableCollection<Order>();

        public TestDataSource() {
            FillEmployees();
            FillProducts();
            FillProductCopies();
            FillOrders();
        }

        // Data fill
        private void FillEmployees() {
            employees.Add(new Employee("Anakin", "Skywalker"));
            employees.Add(new Employee("Mace", "Windu"));
            employees.Add(new Employee("Chirrut", "Imwe"));
            employees.Add(new Employee("Sheev", "Palpatine"));
        }

        private void FillProducts() {
            products.Add(1, new Product("Synergistic Bronze Watch", 0.1));
            products.Add(2, new Product("Heavy Duty Linen Plate", 20.5));
            products.Add(3, new Product("Concrete Computer", 5));
        }

        private void FillProductCopies() {
            productCopies.Add(new ProductCopy(products[1], "Sandcrawler", 12.2, 1));
        }

        private void FillOrders() {
            orders.Add(new Order(employees[0], productCopies[0], 12.0, 1));
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