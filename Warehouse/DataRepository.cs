using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class DataRepository
    {
        private IDataAPI dataService;
        private DataContext dataContext;

        public DataRepository(IDataAPI dataService)
        {
            if (dataService == null)
                throw new ArgumentNullException(nameof(dataService));

            this.dataService = dataService;
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
