using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Caculation caculation;
        [TestInitialize] // thiết lập thẻ dùng chung cho test case
        public void setup()
        {
            caculation = new Caculation(10, 5);
        }
  
  
        [TestMethod] // test case 2
        public void TesAddOperator()
        {
            int expected, actual;
            expected = 15;
            actual = caculation.Execute("+");
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod]
        public void TesSubOperator()
        {
            int expected, actual;
            expected = 5;
            actual = caculation.Execute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TesMulOperator()
        {
            int expected, actual;
            expected = 50;
            actual = caculation.Execute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TesDivOperator()
        {
            int expected, actual;
            expected = 2;
            actual = caculation.Execute("/");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TesDivOperatorByZero()
        {
            caculation = new Caculation(10, 0);
            caculation.Execute("/");
        }
    }
}
