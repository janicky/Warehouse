using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse 
{
    class DataContext
    {
        private List<Employee> employees;
        private Dictionary<int, Product> products;
        private ObservableCollection<Order> orders;
        private ObservableCollection<ProductInfo> productsInformations;
    }
}