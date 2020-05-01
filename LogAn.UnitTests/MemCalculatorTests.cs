using NUnit.Framework;

namespace LogAn.UnitTests
{
    public class MemCalculatorTests
    {
        [Test]
        public void sum_ByDefault_ReturnsZero()
        {
            MemCalculator memCalculator = getMemCalculator();
            int lastTotal = memCalculator.sum();
            Assert.AreEqual(0, lastTotal);
        }

        [Test]
        public void add_WhenCalled_ChangesSum()
        {
            MemCalculator memCalculator = getMemCalculator();
            memCalculator.add(1);
            int total = memCalculator.sum();
            Assert.AreEqual(1, total);
        }

        private MemCalculator getMemCalculator()
        {
            return new MemCalculator();
        }
    }
}