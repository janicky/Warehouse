using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class DataRepository
    {
        private IDataSource dataSource;
        private DataContext dataContext;

        public DataRepository(IDataSource dataSource)
        {
            if (dataSource == null)
                throw new ArgumentNullException(nameof(dataSource));
            this.dataSource = dataSource;
            // Fill data repository using data source
            fillRepository();
        }

        private void fillRepository() {
            // Fill employees collection
            dataContext.employees = dataSource.GetEmployees();
            // Fill products collection
            dataContext.products = dataSource.GetProducts();
            // Fill product copies collection
            dataContext.productCopies = dataSource.GetProductCopies();
            // Fill orders collection
            dataContext.orders = dataSource.GetOrders();
        }

        // Employee CRUD
        public void AddEmployee(Employee employee) {
            dataContext.employees.Add(employee);
        }

        public Employee GetEmployeeByIndex(int index) {
            try {
                return dataContext.employees.ElementAt(index);
            } catch (Exception) {
                return null;
            }
        }

        public Employee GetEmployeeById(int id) {
            try {
                return dataContext.employees.First(e => e.GetId() == id);
            } catch (Exception) {
                return null;
            }
        }

        public void GetAll()
        {
            
        }

        public void Update()
        {
            
        }

        public void Delete()
        {

        }
    }
}
