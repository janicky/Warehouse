using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse {
    class Initializer {
        public Initializer() {
            ConstantData dataService = new ConstantData();
            new DataRepository(dataService);
        }
    }
}
