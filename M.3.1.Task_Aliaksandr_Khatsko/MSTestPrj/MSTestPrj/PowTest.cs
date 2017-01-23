using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestPrj
{

    [TestClass]
    public class PowTest:BaseTestClass
    {
        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestPowIntNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(4, calc.Pow(16, 0.5), "Power of int number works incorrect");
        }

        [TestCleanup]
        public void CleanUp1()
        {
            Console.WriteLine("Test CleanUp");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestPowDoubleNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(12155.0625, calc.Pow(10.5, 4), "Power of int number works incorrect");
        }

        [TestCleanup]
        public void CleanUp2()
        {
            Console.WriteLine("Test CleanUp");
        }

       [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException), "Power of strings was inappropriately allowed.")]
        [Owner("Aliaksandr Khatsko")]
        public void TestPowStr()
        {
            var calc = new Calculator();
            string input1 = "test1";
            string input2 = "test2";
            calc.Pow(input1, input2);
        }

       [TestCleanup]
       public void CleanUp3()
       {
           Console.WriteLine("Test CleanUp");
       }

       [TestMethod]
       [Owner("Aliaksandr Khatsko")]
       public void TestPowStrNum()
       {
           var calc = new Calculator();
           string input1 = "10";
           string input2 = "4";
           Assert.AreEqual(10000, calc.Pow(input1, input2), "Power of string number works incorrect");
       }

       [TestCleanup]
       public void CleanUp4()
       {
           Console.WriteLine("Test CleanUp");
       }

    }
}
