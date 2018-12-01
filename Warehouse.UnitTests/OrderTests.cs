using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.UnitTests
{
    [TestClass]
    public class OrderTests {
        private DataRepository dataRepository;

        [TestInitialize]
        public void TestInitialize() {
            Order.ResetIndex();
            dataRepository = new DataRepository(new TestDataSource());
        }
    }
}
