using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestPrj
{

    [TestClass]
    public class SinTest
    {
        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestSinPosNum()
        {
            var calc = new Calculator();
            double input = Math.PI;
            Assert.AreEqual(0, calc.Sin(input), "Sin function works incorrect");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestSinNegNum()
        {
            var calc = new Calculator();
            double input = -(Math.PI);
            Assert.AreEqual(0, calc.Sin(input), "Sin function works incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException), "Sin function was inappropriately allowed to work with strings.")]
        [Owner("Aliaksandr Khatsko")]
        public void TestSinStr()
        {
            var calc = new Calculator();
            string input1 = "test1";
            calc.Sin(input1);
        }
    }
}
