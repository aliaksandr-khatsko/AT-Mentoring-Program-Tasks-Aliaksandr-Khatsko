using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestPrj
{

    [TestClass]
    public class AbsTest:BaseTestClass
    {
        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestAbsPosNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(100.01, calc.Abs(100.01), "Absolute method works incorrect for positve numbers");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestAbsNegNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(100.01, calc.Abs(-100.01), "Absolute method works incorrect for positve numbers");
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException), "Wrong input")]
        [Owner("Aliaksandr Khatsko")]
        public void TestAbsStr()
        {
            var calc = new Calculator();
            string input1 = "test1";
            calc.Abs(input1);
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestAbsStrNum()
        {
            var calc = new Calculator();
            string input1 = "-100.01";
            Assert.AreEqual(100.01, calc.Abs(input1), "Absolute method works incorrect for string numbers");
        }

    }
}
