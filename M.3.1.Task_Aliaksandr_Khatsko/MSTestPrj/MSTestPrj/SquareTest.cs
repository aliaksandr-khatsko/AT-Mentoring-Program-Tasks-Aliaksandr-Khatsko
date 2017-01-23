using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestPrj
{

    [TestClass]
    public class SquareTest:BaseTestClass
    {
        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestSquarePositiveNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(4, calc.Sqrt(2.1111), "Square method of positive numbers works incorrect");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestSquareZero()
        {
            var calc = new Calculator();
            Assert.AreEqual(0, calc.Sqrt(0), "Square method of zero works incorrect");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestSquareNegNum()
        {
            var calc = new Calculator();

            Assert.AreEqual(4, calc.Sqrt(-2.1111), "Square method of negative numbers works incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException), "Square method was inappropriately allowed for strings")]
        [Owner("Aliaksandr Khatsko")]
        public void TestSquareStr()
        {
            var calc = new Calculator();
            string input1 = "test1";
            calc.Sqrt(input1);
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestSquareStrNum()
        {
            var calc = new Calculator();
            string input1 = "2";
            Assert.AreEqual(4, calc.Sqrt(input1), "Square method of string numbers works incorrect");
        }
        
    }
}
