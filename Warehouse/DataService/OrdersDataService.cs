using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse {
    public partial class DataService {

        public void DisplayOrders(IEnumerable<Order> orders) {
            foreach (Order order in orders) {
                Console.WriteLine(order);
            }
        }

        public Order FindOrder(Func<Order, bool> condition) {
            return repository.GetAllOrders().First(condition);
        }

        public Order AddOrder(Employee employee, ProductCopy productCopy, double price, int count) {
            Order order = new Order(employee, productCopy, price, count);
            repository.AddOrder(order);
            return order;
        }
    }
}
