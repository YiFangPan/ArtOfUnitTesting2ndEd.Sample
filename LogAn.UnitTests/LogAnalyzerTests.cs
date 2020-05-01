using NUnit.Framework;

namespace LogAn.UnitTests
{
    public class LogAnalyzerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsValidLogFileName_Bad_Extenstion_ReturnsFalse()
        {
            Assert.Pass();
        }
    }
}