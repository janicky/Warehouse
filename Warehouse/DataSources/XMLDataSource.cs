using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Warehouse {
    public class XMLDataSource : IDataSource {
        public List<Employee> GetEmployees() {
            using (XmlReader reader = XmlReader.Create("W:/C#/Warehouse/Warehouse/DataSources/DataFiles/Employees.xml")) {
                XmlSerializer serializer = new XmlSerializer(typeof(EmployeeList));
                return ((EmployeeList)serializer.Deserialize(reader)).Employees;
            }
        }
    
        public Dictionary<int, Product> GetProducts() {
            using (XmlReader reader = XmlReader.Create("W:/C#/Warehouse/Warehouse/DataSources/DataFiles/Products.xml")) {
                XmlSerializer serializer = new XmlSerializer(typeof(ProductList));

                List<Product> products = ((ProductList)serializer.Deserialize(reader)).Products;
                Dictionary<int, Product> dictionary = new Dictionary<int, Product>();

                foreach (Product product in products) {
                    dictionary.Add(product.Key, product);
                }

                return dictionary;
            }
        }

        public ObservableCollection<Order> GetOrders() {
            throw new NotImplementedException();
        }

        public ObservableCollection<ProductCopy> GetProductCopies() {
            throw new NotImplementedException();
        }
    }
}
