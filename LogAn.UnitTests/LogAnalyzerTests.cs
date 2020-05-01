using System;
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
        public void IsValidLogFileName_BadExtenstion_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("fileWithBadExtension.foo");
            Assert.False(result);
        }

        [TestCase("fileWithGoodExtension.slf")]
        [TestCase("fileWithGoodExtension.SLF")]
        public void InValidLogFileName_ValidExtensions_ReturnsTrue(String fileName)
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName(fileName);
            Assert.True(result);
        }
    }
}