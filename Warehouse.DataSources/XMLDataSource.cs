using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Warehouse.Model;

namespace Warehouse.DataSources {
    public class XMLDataSource : IDataSource {

        private List<Employee> employees = new List<Employee>();
        private Dictionary<int, Product> products = new Dictionary<int, Product>();
        private ObservableCollection<ProductCopy> productCopies = new ObservableCollection<ProductCopy>();

        public XMLDataSource() {
            FillEmployees();
            FillProducts();
            FillProductCopies();
        }

        public void FillEmployees() {
            using (XmlReader reader = XmlReader.Create("W:/C#/Warehouse/Warehouse.DataSources/DataFiles/Employees.xml")) {
                XmlSerializer serializer = new XmlSerializer(typeof(EmployeeList));
                employees = ((EmployeeList)serializer.Deserialize(reader)).Employees;
            }
        }

        public void FillProducts() {
            using (XmlReader reader = XmlReader.Create("W:/C#/Warehouse/Warehouse.DataSources/DataFiles/Products.xml")) {
                XmlSerializer serializer = new XmlSerializer(typeof(ProductList));

                List<Product> productsList = ((ProductList)serializer.Deserialize(reader)).Products;
                foreach (Product product in productsList) {
                    products.Add(product.Key, product);
                }
            }
        }

        public void FillProductCopies() {
            using (XmlReader reader = XmlReader.Create("W:/C#/Warehouse/Warehouse.DataSources/DataFiles/ProductCopies.xml")) {
                XmlSerializer serializer = new XmlSerializer(typeof(ProductCopies));
                productCopies = ((ProductCopies)serializer.Deserialize(reader)).ProductCopiesCollection;

                foreach (ProductCopy productCopy in productCopies) {
                    Product product = products.Values.First(e => e.GetId() == productCopy.ProductId);
                    if (product == null) {
                        productCopies.Remove(productCopy);
                        continue;
                    }
                    productCopy.SetProduct(product);
                }
            }
        }

        public List<Employee> GetEmployees() {
            return employees;
        }
    
        public Dictionary<int, Product> GetProducts() {
            return products;
        }

        public ObservableCollection<ProductCopy> GetProductCopies() {
            return productCopies;
        }

        public ObservableCollection<Order> GetOrders() {
            throw new NotImplementedException();
        }
    }
}
