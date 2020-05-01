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
        
        [TestCase("fileWithGoodExtension.slf", true)]
        [TestCase("fileWithGoodExtension.SLF", true)]
        [TestCase("fileWithBadExtension.foo", false )]
        public void IsValidLogFileName_VariousExtensions_ReturnsTrue(String fileName, bool expected)
        {
            LogAnalyzer analyzer = getLogAnalyzer();
            bool result = analyzer.IsValidLogFileName(fileName);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsValidLogFileName_EmptyFileName_ThrowException()
        {
            LogAnalyzer analyzer = getLogAnalyzer();
            var ex = Assert.Catch<Exception>(() => analyzer.IsValidLogFileName(String.Empty));
            StringAssert.Contains("filename has to be provided", ex.Message);
        }

        private LogAnalyzer getLogAnalyzer()
        {
            return  new LogAnalyzer();
        }
    }
}