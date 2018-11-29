using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse {
    class Initializer {
        public Initializer() {
            DataFill dataService = new DataFill();
            new DataRepository(dataService);
        }
    }
}
