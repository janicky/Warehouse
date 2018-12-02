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

        public ObservableCollection<Order> GetOrders() {
            throw new NotImplementedException();
        }

        public ObservableCollection<ProductCopy> GetProductCopies() {
            throw new NotImplementedException();
        }

        public Dictionary<int, Product> GetProducts() {
            throw new NotImplementedException();
        }
    }
}
