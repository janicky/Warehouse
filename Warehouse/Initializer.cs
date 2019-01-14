using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.DataSources;

namespace Warehouse {
    class Initializer {
        public Initializer() {
            ConstantDataSource dataService = new ConstantDataSource();
            new DataRepository(dataService);
        }
    }
}
