﻿using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnitPrj
{
    [TestFixture]
    class IsNegative:BaseClass
    {
        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestIsNegativeZero()
        {
            var calc = new Calculator();
            double input = 0;
            Assert.AreEqual(false, calc.isNegative(input), "isNegative function works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestIsNegativePosNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(false, calc.isNegative(0.1), "isNegative function works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestIsNegativeNegNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(true, calc.isNegative(-0.1), "isNegative function works incorrect");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestIsNegativeStr()
        {
            var calc = new Calculator();
            string input1 = "test1";
            Assert.Throws<NotFiniteNumberException>(() => calc.isNegative(input1), "Wrong input");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestIsNegativeStringNum()
        {
            var calc = new Calculator();
            string input1 = "-10";
            Assert.AreEqual(true, calc.isNegative(input1), "IsNegative function works incorrect");
        }

    }
}
