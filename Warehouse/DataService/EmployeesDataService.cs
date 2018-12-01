using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse {
    public partial class DataService {

        public void DisplayEmployees(IEnumerable<Employee> employees) {
            foreach (Employee employee in employees) {
                Console.WriteLine(employee);
            }
        }

    }
}
