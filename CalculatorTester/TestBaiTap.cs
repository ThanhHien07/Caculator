using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CalculatorTester
{
    [TestClass]
    public class TestBaiTap
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void TestPower1()
        {
            double x = 2;
            int n = 0;
            double expected = 1;
            Assert.AreEqual(expected, BaiTap1.Power(x, n));
        }
        [TestMethod]
        public void TestPower2()
        {
            double x = 3;
            int n = 2;
            double expected = 9;
            Assert.AreEqual(expected, BaiTap1.Power(x, n));
        }
        [TestMethod]
        public void TestPower3()
        {
            double x = 2;
            int n = -1;
            double expected = 0.5;
            Assert.AreEqual(expected, BaiTap1.Power(x, n));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPolynomial1()
        {
            int n = 2;
            List<int> a = new List<int> { 1, 2 };
            Polynomial p = new Polynomial(n, a);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPolynomial2()
        {
            int n = 2;
            List<int> a = new List<int> { 1, 2, 3, 4 };
            Polynomial p = new Polynomial(n, a);
        }
        [TestMethod]
        public void TestPolynomial3()
        {
            int n = 2;
            List<int> a = new List<int> { 1, 2, 3 };
            double x = 1;
            int expected = 6;
            Polynomial p = new Polynomial(n, a);
            Assert.AreEqual(expected, p.Cal(x));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRadix1()
        {
            int radix1 = 1;
            int radix2 = 17;
            Radix r1 = new Radix(radix1);
            Radix r2 = new Radix(radix2);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRadix2()
        {
            int number = -1;
            Radix r = new Radix(number);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData3.csv", "TestData3#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestRadix3()
        {
            int number = int.Parse(TestContext.DataRow[0].ToString());
            int radix = int.Parse(TestContext.DataRow[1].ToString());
            string expected = TestContext.DataRow[2].ToString();

            Radix r = new Radix(number);
            Assert.AreEqual(expected, r.ConvertDecimalToAnother(radix));
        }
    }
}
