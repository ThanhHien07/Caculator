using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest2
    {
        SimpleEquation se;
        [TestMethod]
        public void VoNghiem()
        {
            se = new SimpleEquation(0, 2);
            Assert.AreEqual("VN", se.SingleEquation());
        }
        [TestMethod]
        public void VoSoNghiem()
        {
            se = new SimpleEquation(0, 0);
            Assert.AreEqual("VSN", se.SingleEquation());
        }
        public void THMotNghiem()
        {
            se = new SimpleEquation(2, 1);
            Assert.AreEqual("-0.5", se.SingleEquation());
        }
    }
}
