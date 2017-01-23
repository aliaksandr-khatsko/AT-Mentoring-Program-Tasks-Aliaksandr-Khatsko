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

        [TestCleanup]
        public void CleanUp1()
        {
            Console.WriteLine("Test CleanUp");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestAbsNegNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(100.01, calc.Abs(-100.01), "Absolute method works incorrect for positve numbers");
        }

        [TestCleanup]
        public void CleanUp2()
        {
            Console.WriteLine("Test CleanUp");
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

        [TestCleanup]
        public void CleanUp3()
        {
            Console.WriteLine("Test CleanUp");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestAbsStrNum()
        {
            var calc = new Calculator();
            string input1 = "-100.01";
            Assert.AreEqual(100.01, calc.Abs(input1), "Absolute method works incorrect for string numbers");
        }

        [TestCleanup]
        public void CleanUp4()
        {
            Console.WriteLine("Test CleanUp");
        }
    }
}
