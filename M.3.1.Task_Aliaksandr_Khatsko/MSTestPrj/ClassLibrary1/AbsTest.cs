using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnitPrj
{
    [TestFixture]
    class AbsTest:BaseClass
    {
        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestAbsPosNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(100.01, calc.Abs(100.01), "Absolute method works incorrect for positve numbers");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestAbsNegNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(100.01, calc.Abs(-100.01), "Absolute method works incorrect for positve numbers");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestAbsStr()
        {
            var calc = new Calculator();
            string input1 = "test1";
            Assert.Throws<NotFiniteNumberException>(() => calc.Abs(input1), "Wrong input");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestAbsStrNum()
        {
            var calc = new Calculator();
            string input1 = "-100.01";
            Assert.AreEqual(100.01, calc.Abs(input1), "Absolute method works incorrect for string numbers");
        }

    }
}
