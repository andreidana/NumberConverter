using ConverterLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConverterLibTests
{
    [TestClass]
    public class BaseTwoTests
    {
        NumericConverter converter;

        [TestInitialize]
        public void setup()
        {
            converter = new NumericConverter(2);
        }

        [TestMethod]
        public void WhenGiven0AsInputShouldReturn0()
        {
            Assert.AreEqual("0", converter.Convert(0));
        }

        [TestMethod]
        public void WhenGiven1AsInputShouldReturn1()
        {
            Assert.AreEqual("1", converter.Convert(1));
        }

        [TestMethod]
        public void WhenGiven2AsInputShouldReturn10()
        {
            Assert.AreEqual("10", converter.Convert(2));
        }

        [TestMethod]
        public void WhenGiven3AsInputShouldReturn11()
        {
            Assert.AreEqual("11", converter.Convert(3));
        }

        [TestMethod]
        public void WhenGiven4AsInputShouldReturn100()
        {
            Assert.AreEqual("100", converter.Convert(4));
        }

        [TestMethod]
        public void WhenGiven5AsInputShouldReturn101()
        {
            Assert.AreEqual("101", converter.Convert(5));
        }

        [TestMethod]
        public void WhenGiven123456789AsInputShouldReturn111010110111100110100010101()
        {
            Assert.AreEqual("111010110111100110100010101", converter.Convert(123456789));
        }
    }
}
