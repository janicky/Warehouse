using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse {
    public partial class DataRepository {
        // CRUD methods for Orders in this partial class
        public void AddOrder(Order order) {
            dataContext.orders.Add(order);
        }
    }
}
