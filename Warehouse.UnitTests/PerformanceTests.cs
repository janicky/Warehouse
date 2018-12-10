using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.UnitTests {
    [TestClass]
    public class PerformanceTests {

        private TimeSpan Time(Action task) {
            var timer = Stopwatch.StartNew();
            task();
            timer.Stop();
            return timer.Elapsed;
        }

        public TestContext TestContext { get; set; }

        [TestMethod]
        public void PerformanceTestOne() {
            var elapsed = Time(() => new DataRepository(new RandomDataSource(10000)));
            Assert.IsTrue(elapsed < TimeSpan.FromSeconds(3.7));
            TestContext.WriteLine(elapsed.ToString());
        }
    }
}
