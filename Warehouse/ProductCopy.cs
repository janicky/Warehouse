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

        private int id = index++;
        private Product product;
        private string description;
        private double price;
        private int count;
        
        private Order order;
        private DateTimeOffset createdAt;
        private DateTimeOffset updatedAt;

        public ProductCopy(Product product, string description, double price, int count) {
            this.product = product;
            this.description = description;
            this.price = price;
            this.count = count;
            order = null;
            createdAt = DateTimeOffset.Now;
            updatedAt = DateTimeOffset.Now;

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

        public void SetProduct(Product product) {
            this.product = product;
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

        public void Updated() {
            updatedAt = DateTimeOffset.Now;
        }
    }
}
