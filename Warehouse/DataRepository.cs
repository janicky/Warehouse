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

        public DataRepository(IDataSource dataService)
        {
            if (dataService == null)
                throw new ArgumentNullException(nameof(dataService));

            this.dataSource = dataService;
        }

        public void Add()
        {

        }

        public void Get()
        {
            
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
