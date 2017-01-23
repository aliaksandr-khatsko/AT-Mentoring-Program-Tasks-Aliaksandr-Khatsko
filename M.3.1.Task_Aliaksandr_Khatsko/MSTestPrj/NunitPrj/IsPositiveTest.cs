using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestPrj
{

    [TestClass]
    public class IsPositive:BaseTestClass
    {
        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestIsPositiveZero()
        {
            var calc = new Calculator();
            Assert.AreEqual(false, calc.isPositive(0), "IsPositive function works incorrect");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestIsPositivePosNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(true, calc.isPositive(0.1), "IsPositive function works incorrect");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestIsPositiveNegNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(false, calc.isPositive(-0.1), "IsPositive function works incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException), "isPositive function inappropriately allowed to work with strings.")]
        [Owner("Aliaksandr Khatsko")]
        public void TestIsPositiveStr()
        {
            var calc = new Calculator();
            string input1 = "test1";
            calc.isPositive(input1);
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestIsPositiveStringNum()
        {
            var calc = new Calculator();
            string input1 = "10";
            Assert.AreEqual(true, calc.isPositive(input1), "IsPositive function works incorrect");
        }
    }
}
