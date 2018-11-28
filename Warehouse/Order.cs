using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Order
    {
        private Employee employee;
        private ProductCopy productCopy;
        private DateTimeOffset orderDate;
        private double price;
        private int count;

        public Order(Employee employee, ProductCopy productCopy, double price, int count){
            this.employee = employee;
            this.productCopy = productCopy;
            this.price = price;
            this.count = count;
            orderDate = DateTimeOffset.Now;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetCount()
        {
            return count;
        }

    }
}
