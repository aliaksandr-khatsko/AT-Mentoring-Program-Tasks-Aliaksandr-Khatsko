using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnitPrj
{
    [TestFixture]
    class IsPositive:BaseClass
    {
        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestIsPositiveZero()
        {
            var calc = new Calculator();
            Assert.AreEqual(false, calc.isPositive(0), "IsPositive function works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestIsPositivePosNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(true, calc.isPositive(0.1), "IsPositive function works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestIsPositiveNegNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(false, calc.isPositive(-0.1), "IsPositive function works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestIsPositiveStr()
        {
            var calc = new Calculator();
            string input1 = "test1";
            Assert.Throws<NotFiniteNumberException>(() => calc.isPositive(input1), "Wrong input");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestIsPositiveStringNum()
        {
            var calc = new Calculator();
            string input1 = "10";
            Assert.AreEqual(true, calc.isPositive(input1), "IsPositive function works incorrect");
        }

    }
}
