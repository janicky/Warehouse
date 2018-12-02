using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Warehouse {
    class XMLDataSource : IDataSource {
        public List<Employee> GetEmployees() {
            StreamReader reader = new StreamReader("./DataFiles/Employees/xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
            return (List<Employee>) serializer.Deserialize(reader);
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
