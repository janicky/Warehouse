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

        private Random rng = new Random();

        private int multiplier;

        public RandomDataSource(int multiplier = 1) {
            this.multiplier = multiplier;

            FillEmployees();
            FillProducts();
        }

        public void FillEmployees() {
            for (int i = 0; i < multiplier * 1; i++) {
                employees.Add(new Employee(Faker.Name.First(), Faker.Name.Last()));
            }
        }

        public void FillProducts() {
            for (int i = 0; i < multiplier * 5; i++) {
                products.Add((i + 1), new Product(Faker.Company.Name(), rng.NextDouble()));
            }
        }

        public void FillProductCopies() {
            for (int i = 0; i < multiplier * 20; i++) {
                Product product = products[rng.Next(products.Count)];
                productCopies.Add(new ProductCopy(product, Faker.Lorem.Sentence(), rng.NextDouble(), rng.Next()));
            }
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
