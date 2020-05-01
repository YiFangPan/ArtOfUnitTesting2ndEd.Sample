using NUnit.Framework;

namespace LogAn.UnitTests
{
    public class MemCalculatorTests
    {
        public void sum_ByDefault_ReturnsZero()
        {
            MemCalculator memCalculator = new MemCalculator();
            int lastTotal = memCalculator.sum();
            Assert.AreEqual(0, lastTotal);
        }
    }
}