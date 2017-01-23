using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestPrj
{

    [TestClass]
    public class IsNegative:BaseTestClass
    {
        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestIsNegativeZero()
        {
            var calc = new Calculator();
            double input = 0;
            Assert.AreEqual(false, calc.isNegative(input), "isNegative function works incorrect");
        }

        [TestCleanup]
        public void CleanUp1()
        {
            Console.WriteLine("Test CleanUp");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestIsNegativePosNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(false, calc.isNegative(0.1), "isNegative function works incorrect");
        }

        [TestCleanup]
        public void CleanUp2()
        {
            Console.WriteLine("Test CleanUp");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestIsNegativeNegNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(true, calc.isNegative(-0.1), "isNegative function works incorrect");
        }

        [TestCleanup]
        public void CleanUp3()
        {
            Console.WriteLine("Test CleanUp");
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException), "isNegative function inappropriately allowed to work with strings.")]
        [Owner("Aliaksandr Khatsko")]
        public void TestIsNegativeStr()
        {
            var calc = new Calculator();
            string input1 = "test1";
            calc.isNegative(input1);
        }

        [TestCleanup]
        public void CleanUp4()
        {
            Console.WriteLine("Test CleanUp");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestIsNegativeStringNum()
        {
            var calc = new Calculator();
            string input1 = "-10";
            Assert.AreEqual(true, calc.isNegative(input1), "IsNegative function works incorrect");
        }

        [TestCleanup]
        public void CleanUp5()
        {
            Console.WriteLine("Test CleanUp");
        }
    }
}
