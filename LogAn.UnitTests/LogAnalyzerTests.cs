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
        public void InValidLogFileName_VariousExtensions_ReturnsTrue(String fileName, bool expected)
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName(fileName);
            Assert.AreEqual(expected, result);
        }
    }
}