using CSharpCalculator;
using NUnit.Framework;
using System;

namespace NUnitPrj
{
    [TestFixture]
    class MultiplyTest:BaseClass
    {
        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestMultiplyPositiveNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(6.25, calc.Multiply(2.5, 2.5), "Multiply of 2 positive numbers works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestMultiplyPosNegNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(-6.25, calc.Multiply(-2.5, 2.5), "Multiply of positive and numbers works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestMultiplyNegNum()
        {
            var calc = new Calculator();

            Assert.AreEqual(6.25, calc.Multiply(-2.5, -2.5), "Multiply of 2 negative numbers works incorrect");
        }

    }
}
