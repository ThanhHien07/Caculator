using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        Calculation cal;
        [TestInitialize]

        public void SetUp()
        {
            cal = new Calculation(10, 5);
        }

        [TestMethod]
        public void TestAddOperator()
        {
            Assert.AreEqual(15, cal.Execute("+"));
        }

        [TestMethod]
        public void TestSubOperator()
        {
            Assert.AreEqual(5, cal.Execute("-"));
        }

        [TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(cal.Execute("*"), 50);
        }

        [TestMethod]
        public void TestDivOperator()
        {
            Assert.AreEqual(cal.Execute("/"), 2);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(2, 0);
            c.Execute("/");
        }
    }
}
