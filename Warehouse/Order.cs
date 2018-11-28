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
            this.orderDate = DateTimeOffset.Now;
            this.countPrice = price;
            this.count = count;
        }
    }
}
