using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Order
    {
        private static int index = 0;

        private int id;
        private Employee employee;
        private ProductCopy productCopy;
        private DateTimeOffset orderDate;
        private double price;
        private int count;

        public Order(Employee employee, ProductCopy productCopy, double price = 0, int count = 0, int id = -1){
            this.id = (id != -1 ? id : index++);
            this.employee = employee;
            this.productCopy = productCopy;
            this.price = (price > 0 ? price : 1);
            this.count = (count >= 0 ? count : 0);
            orderDate = DateTimeOffset.Now;
        }

        public static void ResetIndex() {
            index = 0;
        }

        public int GetId() {
            return id;
        }

        public Employee GetEmployee() {
            return employee;
        }

        public ProductCopy GetProductCopy() {
            return productCopy;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetCount()
        {
            return count;
        }

        public DateTimeOffset GetOrderDate() {
            return orderDate;
        }

        public void SetPrice(double price) {
            this.price = (price > 0 ? price : 1); ;
        }

        public void SetCount(int count) {
            this.count = (count >= 0 ? count : 0);
        }

        public override bool Equals(object obj) {
            var item = obj as Order;
            if (item == null) {
                return false;
            }
            return item.GetId() == id &&
                   item.GetCount() == count &&
                   item.GetEmployee() == employee &&
                   item.GetProductCopy() == productCopy;
        }

        public override int GetHashCode() {
            return id.GetHashCode();
        }

        public override string ToString() {
            return id.ToString() + " " + employee.ToString() + " " + productCopy.ToString();
        }
    }
}
