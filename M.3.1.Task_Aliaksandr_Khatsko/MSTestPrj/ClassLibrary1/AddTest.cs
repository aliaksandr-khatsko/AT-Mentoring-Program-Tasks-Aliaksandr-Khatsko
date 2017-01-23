using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnitPrj
{
    [TestFixture]
    class AddTest:BaseClass
    {
        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestAddPositiveDoubleNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(4.5, calc.Add(2.25, 2.25), "Adding of 2 positive numbers works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestAddPosNegDoubleNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(0, calc.Add(-2.25, 2.25), "Adding of positive and numbers works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestAddNegDoubleNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(-4.5, calc.Add(-2.25, -2.25), "Adding of 2 negative numbers works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestAddCorrectStrPos()
        {
            var calc = new Calculator();
            Assert.AreEqual(4.5, calc.Add("2.25", "2.25"), "Adding of 2 string numbers works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestAddStr()
        {
            var calc = new Calculator();
            string input1 = "test1";
            string input2 = "test2";
            Assert.Throws<NotFiniteNumberException>(() => calc.Add(input1, input2), "Wrong input");
        }

    }
}
