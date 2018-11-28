using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class ProductCopy
    {
        private string description;
        private DateTimeOffset createdAt;
        private double price;
        private int count;
        private Product product;

        public string getDescription() {
            return description;
        }

        public DateTimeOffset getCreatedAt() {
            return createdAt;
        }

        public double getPrice() {
            return price;
        }

        public int getCount() {
            return count;
        }

        public Product getProduct() {
            return product;
        }
    }
}
