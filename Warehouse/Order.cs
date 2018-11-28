using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class Order
    {
        private Employee employee;
        private DateTimeOffset orderDate;
        private double price;
        private int count;

        public Order(Employee employee, double price, int count){
            this.employee = employee;
            this.price = price;
            this.count = count;
            orderDate = DateTimeOffset.Now;
        }
    }
}
