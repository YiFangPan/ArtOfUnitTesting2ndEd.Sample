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
        public void isValidLogFileName_VariousExtensions_ReturnsTrue(String fileName, bool expected)
        {
            LogAnalyzer analyzer = getLogAnalyzer();
            bool result = analyzer.isValidLogFileName(fileName);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void isValidLogFileName_EmptyFileName_ThrowException()
        {
            LogAnalyzer analyzer = getLogAnalyzer();
            var ex = Assert.Catch<Exception>(() => analyzer.isValidLogFileName(String.Empty));
            StringAssert.Contains("filename has to be provided", ex.Message);
        }

        [TestCase("badFile.foo", false)]
        [TestCase("goodFile.slf", true)]
        public void isValidLogFileName_WhenCalled_ChangesLastFileNameValid(String fileName, bool expected)
        {
            LogAnalyzer analyzer = getLogAnalyzer();
            analyzer.isValidLogFileName(fileName);
            Assert.AreEqual(expected, analyzer.isLastFileNameValid);
        }
        
        private LogAnalyzer getLogAnalyzer()
        {
            return  new LogAnalyzer();
        }
    }
}