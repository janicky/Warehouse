using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse {
    class Initializer {
        public Initializer() {
            DataService dataService = new DataService();
            new DataRepository(dataService);
        }
    }
}
