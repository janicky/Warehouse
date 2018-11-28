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
        private double countPrice;
        private int count;

        public Order(Employee employee, DateTimeOffset orderDate, double countPrice, int count){
            this.employee = employee;
            this.orderDate = orderDate;
            this.countPrice = countPrice;
            this.count = count;
        }
    }
}
