using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse {
    public partial class DataRepository {
        // CRUD methods for Employees in this partial class
        public void AddEmployee(Employee employee) {
            dataContext.employees.Add(employee);
        }

        public Employee GetEmployeeByIndex(int index) {
            try {
                return dataContext.employees.ElementAt(index);
            }
            catch (Exception) {
                return null;
            }
        }

        public Employee GetEmployeeById(int id) {
            try {
                return dataContext.employees.First(e => e.GetId() == id);
            }
            catch (Exception) {
                return null;
            }
        }

        public List<Employee> GetAllEmployees() {
            return dataContext.employees;
        }

        public void UpdateEmployee(Employee employee) {
            Employee updatingEmployee = GetEmployeeById(employee.GetId());
            if (updatingEmployee != null) {
                updatingEmployee.SetFirstName(employee.GetFirstName());
                updatingEmployee.SetLastName(employee.GetLastName());
            }
        }

        public bool DeleteEmployee(Employee employee) {
            try {
                return dataContext.employees.Remove(employee);
            } catch (Exception) {
                return false;
            }
        }
    }
}
