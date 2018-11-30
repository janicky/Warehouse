﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse {
    public class Product {

        private static int index = 0;

        private int id;
        private string name;
        private double weight;
        private ObservableCollection<ProductCopy> productCopies = new ObservableCollection<ProductCopy>();

        public Product(string name, double weight, int id = -1) {
            id = (id != -1 ? id : index++);
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

        public ObservableCollection<ProductCopy> GetProductCopies() {
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

        public void SetProductCopies(ObservableCollection<ProductCopy> productCopies) {
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

        public override bool Equals(object obj) {
            var item = obj as Product;
            if (item == null) {
                return false;
            }
            return id == item.GetId() &&
                   name.Equals(item.GetName()) &&
                   weight == item.GetWeight();
        }

        public override int GetHashCode() {
            return id.GetHashCode();
        }

        public override string ToString() {
            return name;
        }
    }
}
