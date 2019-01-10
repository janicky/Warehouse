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

        // RandomDataSource(multiplier)
        // Employees * 1 * multiplier, 
        // Products * 5 * multiplier, 
        // ProductCopies * 20 * multiplier, 
        // Orders * 40 * multiplier

        [TestMethod]
        public void PerformanceTestOne() {
            // 66 * 1000 = 66 000 objects
            var elapsed = Time(() => new DataRepository(new RandomDataSource(1000)));
            Assert.IsTrue(elapsed < TimeSpan.FromMilliseconds(500));
            TestContext.WriteLine(elapsed.ToString());
        }

        [TestMethod]
        public void PerformanceTestTwo() {
            // 66 * 5000 = 330 000 objects
            var elapsed = Time(() => new DataRepository(new RandomDataSource(5000)));
            Assert.IsTrue(elapsed < TimeSpan.FromMilliseconds(2500));
            TestContext.WriteLine(elapsed.ToString());
        }

        [TestMethod]
        public void PerformanceTestThree() {
            // 66 * 6000 = 396 000 objects
            var elapsed = Time(() => new DataRepository(new RandomDataSource(6000)));
            Assert.IsTrue(elapsed < TimeSpan.FromMilliseconds(3500));
            TestContext.WriteLine(elapsed.ToString());
        }

        [TestMethod]
        public void PerformanceTestFour() {
            // 66 * 6500 = 429 000 objects
            var elapsed = Time(() => new DataRepository(new RandomDataSource(6500)));
            Assert.IsTrue(elapsed < TimeSpan.FromMilliseconds(4500));
            TestContext.WriteLine(elapsed.ToString());
        }
    }
}
