using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse {
    public partial class DataService {
        public void DisplayProducts(Dictionary<int, Product> products) {
            foreach (Product product in products.Values) {
                Console.WriteLine(product);
            }
        }
    }
}
