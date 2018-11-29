using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Warehouse {
    public interface IDataSource {
        List<Employee> GetEmployees();
        Dictionary<int, Product> GetProducts();
        ObservableCollection<ProductCopy> GetProductCopies();
        ObservableCollection<Order> GetOrders();
    }
}
