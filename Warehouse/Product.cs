﻿using System;
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
        private List<ProductCopy> productCopies;

        public Product(string name, double weight) {
            id = index++;
            this.name = name;
            this.weight = weight;
        }

        public int GetId()
        {
            return id;
        }

        public string GetName() {
            return name;
        }

        public double GetWeight() {
            return weight;
        }

        public List<ProductCopy> GetProductCopies() {
            return productCopies;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }

        public void SetProductCopies(List<ProductCopy> productCopies) {
            this.productCopies = productCopies;
        }

        public void AddProductCopy(ProductCopy productCopy) {
            productCopies.Add(productCopy);
        }

        public void RemoveProductCopy(ProductCopy productCopy) {
            try {
                bool deleted = productCopies.Remove(productCopy);
            } catch (Exception) {
                throw new NotImplementedException();
            }
        }
    }
}
