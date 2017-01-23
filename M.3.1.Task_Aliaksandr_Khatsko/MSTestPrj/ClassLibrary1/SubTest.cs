using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnitPrj
{
    [TestFixture]
    class SubTest:BaseClass
    {
        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestSubPosNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(8.75, calc.Sub(10, 1.25), "Substitution of positive numbers works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestSubPosNegNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(-7.25, calc.Sub(-5.25, 2), "Substitution of positive and numbers works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestSubNegNum()
        {
            var calc = new Calculator();

            Assert.AreEqual(0, calc.Sub(-2.25, -2.25), "Substitution of 2 negative numbers works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestSubStr()
        {
            var calc = new Calculator();
            string input1 = "test";
            string input2 = "test";
            Assert.Throws<NotFiniteNumberException>(() => calc.Sub(input1, input2), "Wrong input");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestSubStrNum()
        {
            var calc = new Calculator();
            string input1 = "2.25";
            string input2 = "2.25";
            Assert.AreEqual(0, calc.Sub(input1, input2), "Substitution of 2 strings numbers works incorrect");
        }

    }
}
