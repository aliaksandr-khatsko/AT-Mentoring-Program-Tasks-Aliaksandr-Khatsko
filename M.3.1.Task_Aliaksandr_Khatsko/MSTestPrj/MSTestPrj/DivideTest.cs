using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestPrj
{

    [TestClass]
    public class DivideTest:BaseTestClass
    {
  
        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestDivPositiveNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(1, calc.Divide(2.25, 2.25), "Dividing of positive and numbers works incorrect");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestDivPosNegNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(-1, calc.Divide(-2.25, 2.25), "Dividing of positive and numbers works incorrect");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestDivNegNum()
        {
            var calc = new Calculator();

            Assert.AreEqual(1, calc.Divide(-2.25, -2.25), "Dividing of 2 negative numbers works incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException), "Divide by zero was inappropriately allowed.")]
        [Owner("Aliaksandr Khatsko")]
        public void TestDivideByZero()
        {
            var calc = new Calculator();
            calc.Divide(10, 0);
        }

    }
}
