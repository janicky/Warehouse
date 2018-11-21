using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class ProductInfo
    {
        private string description;
        private DateTimeOffset addDate;
        private double price;
        private int count;
        private Product product;

        public Product getProduct() {
            return product;
        }
    }
}
