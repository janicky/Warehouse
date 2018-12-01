using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Warehouse {
    class DataService {

        private DataRepository repository;

        public DataService(DataRepository repository) {
            this.repository = repository;
        }

        public Dictionary<int, Product> GetAllProducts() {
            return repository.GetAllProducts();
        }

    }
}