﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class DataRepository
    {
        private DataContext dataContext;

        public DataRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;

        }
    }
}
