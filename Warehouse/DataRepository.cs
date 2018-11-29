using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public partial class DataRepository
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
    }
}
