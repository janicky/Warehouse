using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Warehouse {

    [XmlRoot("Products")]
    public class ProductList {
        public ProductList() {
            Products = new List<Product>();
        }

        [XmlElement("Product")]
        public List<Product> Products { get; set; }
    }

    public class Product {

        private static int index = 0;

        private int id;
        private string name;
        private double weight;
        private ObservableCollection<ProductCopy> productCopies = new ObservableCollection<ProductCopy>();

        [XmlElement("Key")]
        public int Key { get; set; }

        [XmlElement("Name")]
        public string Name {
            get {
                return GetName();
            }
            set {
                SetName(value);
            }
        }

        [XmlElement("Weight")]
        public double Weight {
            get {
                return GetWeight();
            }
            set {
                SetWeight(value);
            }
        }

        private Product() { }

        public Product(string name, double weight, int id = -1) {
            this.id = (id != -1 ? id : index++);
            this.name = name;
            this.weight = (weight >= 0 ? weight : 0);
        }

        public static void ResetIndex() {
            index = 0;
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
            this.weight = (weight >= 0 ? weight : 0);
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
                if (!deleted) throw new Exception();
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
            return string.Format("Product: {0} \n", name);
        }
    }
}
