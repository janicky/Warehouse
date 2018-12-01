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
    }
}
