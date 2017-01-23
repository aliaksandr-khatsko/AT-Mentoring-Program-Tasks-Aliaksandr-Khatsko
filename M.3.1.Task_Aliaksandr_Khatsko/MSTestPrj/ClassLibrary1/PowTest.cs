using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnitPrj
{
    [TestFixture]
    class PowTest:BaseClass
    {
        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestPowIntNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(4, calc.Pow(16, 0.5), "Power of int number works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestPowDoubleNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(12155.0625, calc.Pow(10.5, 4), "Power of int number works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestPowStr()
        {
            var calc = new Calculator();
            string input1 = "test1";
            string input2 = "test2";
            Assert.Throws<NotFiniteNumberException>(() => calc.Pow(input1, input2), "Wrong input");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestPowStrNum()
        {
            var calc = new Calculator();
            string input1 = "10";
            string input2 = "4";
            Assert.AreEqual(10000, calc.Pow(input1, input2), "Power of string number works incorrect");
        }

    }
}
