using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse {
    public class Product {

        private static int index = 0;

        private int id;
        private string name;
        private double weight;
        private List<ProductInfo> productInfos;

        public Product(string name, double weight) {
            id = index++;
            this.name = name;
            this.weight = weight;
        }

        public string GetName() {
            return name;
        }

        public double GetWeight() {
            return weight;
        }

        public List<ProductInfo> GetProductInfos() {
            return productInfos;
        }

    }
}
