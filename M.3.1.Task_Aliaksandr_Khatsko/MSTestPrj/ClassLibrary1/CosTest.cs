using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnitPrj
{
    [TestFixture]
    class CosTest:BaseClass
    {
        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestCosPosNum()
        {
            var calc = new Calculator();
            double input = Math.PI;
            Assert.AreEqual(-1, calc.Cos(input), "Cos function works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestCosNegNum()
        {
            var calc = new Calculator();
            double input = -(Math.PI);
            Assert.AreEqual(-1, calc.Cos(input), "Cos function works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestCosStr()
        {
            var calc = new Calculator();
            string input1 = "test3";
            Assert.Throws<NotFiniteNumberException>(() => calc.Cos(input1), "Wrong input");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestCosNumStrng()
        {
            var calc = new Calculator();
            string input1 = "90";
            double expectedResut = -0.44807361612917015236547731439964;
            Assert.AreEqual(expectedResut, calc.Cos(input1), "Cos function works incorrect");
        }

    }
}
