using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Model;

namespace Warehouse 
{
    public class DataContext
    {
        public List<Employee> employees;
        public Dictionary<int, Product> products;
        public ObservableCollection<Order> orders;
        public ObservableCollection<ProductCopy> productCopies;
    }
}