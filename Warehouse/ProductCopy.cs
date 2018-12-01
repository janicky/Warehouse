using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class ProductCopy
    {
        private static int index = 0;

        private int id;
        private Product product;
        private string description;
        private double price;
        private int count;
        
        private Order order;
        private DateTimeOffset createdAt;
        private DateTimeOffset updatedAt;

        public ProductCopy(Product product, string description, double price, int count, int id = -1) {
            this.id = (id != -1 ? id : index++);
            this.product = product;
            this.description = description;
            this.price = price;
            this.count = count;
            order = null;
            createdAt = DateTimeOffset.Now;
            updatedAt = DateTimeOffset.Now;
            product.AddProductCopy(this);
        }

        ~ProductCopy() {
            product.RemoveProductCopy(this);
        }

        public static void ResetIndex() {
            index = 0;
        }

        public int GetId() {
            return id;
        }

        public Product GetProduct() {
            return product;
        }

        public string GetDescription() {
            return description;
        }

        public double GetPrice() {
            return price;
        }

        public int GetCount() {
            return count;
        }

        public DateTimeOffset GetCreatedAt() {
            return createdAt;
        }

        public DateTimeOffset GetUpdatedAt() {
            return updatedAt;
        }

        public void SetProduct(Product product) {
            this.product.RemoveProductCopy(this);
            this.product = product;
            product.AddProductCopy(this);
            Updated();
        }

        public void SetDescription(string description) {
            this.description = description;
            Updated();
        }

        public void SetPrice(double price) {
            this.price = price;
            Updated();
        }

        public void SetCount(int count) {
            this.count = count;
            Updated();
        }

        private void Updated() {
            updatedAt = DateTimeOffset.Now;
        }

        public override bool Equals(object obj) {
            var item = obj as ProductCopy;
            if (item == null) {
                return false;
            }

            return id == item.GetId() && 
                   description.Equals(item.GetDescription()) &&
                   price.Equals(item.GetPrice()) &&
                   count.Equals(item.GetCount());
        }

        public override int GetHashCode() {
            return id.GetHashCode();
        }

        public override string ToString() {
            StringBuilder str = new StringBuilder();
            str.Append(string.Format("ProductCopy: {0} ${1} [{2}x]\n", description, price, count));

            if (order != null) {
                str.Append(order);
            }
            return str.ToString();
        }
    }
}
