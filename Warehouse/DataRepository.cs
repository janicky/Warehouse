using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class DataRepository
    {
        private IDataService dataService;
        private DataContext dataContext;

        public DataRepository(IDataService dataService)
        {
            if (dataService == null)
                throw new ArgumentNullException(nameof(dataService));

            this.dataService = dataService;
        }
    }
}
