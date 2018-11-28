using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class ProductCopy
    {
        private Product product;
        private string description;
        private double price;
        private int count;
        
        private Order order;
        private DateTimeOffset createdAt;

        public ProductCopy(Product product, string description, double price, int count) {
            this.product = product;
            this.description = description;
            this.price = price;
            this.count = count;
            this.order = null;
            this.createdAt = DateTimeOffset.Now;
        }

        public Product getProduct() {
            return product;
        }

        public string getDescription() {
            return description;
        }

        public double getPrice() {
            return price;
        }

        public int getCount() {
            return count;
        }

        public DateTimeOffset getCreatedAt() {
            return createdAt;
        }
    }
}
