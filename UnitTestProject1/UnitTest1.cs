using Caculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Caculation cal;
        [TestInitialize]
        public void SetUp()
        {
            this.cal = new Caculation(10, 5);
        }
        [
        TestMethod]
        public void TestAddOperator()
        {
            Assert.AreEqual(cal.Execute("+"), 15);
        }
        [
        TestMethod]
        public void TestSubOperator()
        {
            Assert.AreEqual(cal.Execute("-"), 5);
        }
        [
        TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(cal.Execute("*"), 50);
        }
        [
        TestMethod]
        public void TestDivOperator()
        {
            Assert.AreEqual(cal.Execute("/"), 2);
        }
        [
        TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Caculation c = new Caculation(2, 0);
            c.Execute("/");
        }

        //[TestMethod]
        //public void TestDivRound()
        //{
        //    Caculation c = new Caculation(5, 3);
        //    Assert.AreEqual(c.Execute("/"), 2);
        //}

        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
@".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            Caculation c = new Caculation(a, b);
            int actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
    }
}
