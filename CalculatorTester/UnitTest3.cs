using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest3
    {
        public TestContext TestContext { get; set; }
        Calculation cal;
        //[TestInitialize]
        //public void SetUp()
        //{
        //    cal = new Calculation(10, 5);
        //}
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            Calculation cal = new Calculation(a, b);
            Assert.AreEqual(expected, cal.Execute("+"));
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData2.csv", "TestData2#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource2()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            string o = TestContext.DataRow[2].ToString();
            o = o.Remove(0, 1);
            int expected = int.Parse(TestContext.DataRow[3].ToString());
            Calculation cal = new Calculation(a, b);
            Assert.AreEqual(expected, cal.Execute(o));
        }
    }
}
