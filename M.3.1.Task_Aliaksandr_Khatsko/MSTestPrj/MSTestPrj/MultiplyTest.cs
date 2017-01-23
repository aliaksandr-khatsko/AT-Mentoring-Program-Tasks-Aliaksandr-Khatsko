using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;
using System;

namespace MSTestPrj
{

    [TestClass]
    public class MultiplyTest:BaseTestClass
    {

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestMultiplyPositiveNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(6.25, calc.Multiply(2.5, 2.5), "Multiply of 2 positive numbers works incorrect");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestMultiplyPosNegNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(-6.25, calc.Multiply(-2.5, 2.5), "Multiply of positive and numbers works incorrect");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestMultiplyNegNum()
        {
            var calc = new Calculator();

            Assert.AreEqual(6.25, calc.Multiply(-2.5, -2.5), "Multiply of 2 negative numbers works incorrect");
        }

    }
}
