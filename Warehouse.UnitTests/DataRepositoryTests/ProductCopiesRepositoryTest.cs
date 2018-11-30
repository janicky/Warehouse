using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.UnitTests.DataRepositoryTests {
    [TestClass]
    public class ProductCopiesRepositoryTest {
        private DataRepository dataRepository;

        [TestMethod]
        public void TestInitialize() {
            dataRepository = new DataRepository(new TestDataSource());
        }
    }
}
