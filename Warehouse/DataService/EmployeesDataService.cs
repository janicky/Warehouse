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

        public Employee AddEmployee(string firstName, string lastName) {
            Employee employee = new Employee(firstName, lastName);
            repository.AddEmployee(employee);
            return employee;
        }

        public bool DeleteEmployee(Func<Employee, bool> condition) {
            try {
                Employee employee = repository.GetAllEmployees().First(condition);
                return repository.DeleteEmployee(employee);
            } catch (Exception) {
                return false;
            }
        }

        public void UpdateEmployee(Employee employee) {
            repository.UpdateEmployee(employee);
        }
    }
}
