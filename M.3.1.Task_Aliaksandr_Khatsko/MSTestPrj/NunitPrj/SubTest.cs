using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestPrj
{

    [TestClass]
    public class SubTest:BaseTestClass
    {

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestSubPosNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(8.75, calc.Sub(10, 1.25), "Substitution of positive numbers works incorrect");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestSubPosNegNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(-7.25, calc.Sub(-5.25, 2), "Substitution of positive and numbers works incorrect");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestSubNegNum()
        {
            var calc = new Calculator();

            Assert.AreEqual(0, calc.Sub(-2.25, -2.25), "Substitution of 2 negative numbers works incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException), "Substitution of strings was inappropriately allowed.")]
        [Owner("Aliaksandr Khatsko")]
        public void TestSubStr()
        {
            var calc = new Calculator();
            string input1 = "test";
            string input2 = "test";
            calc.Sub(input1, input2);
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestSubStrNum()
        {
            var calc = new Calculator();
            string input1 = "2.25";
            string input2 = "2.25";
            Assert.AreEqual(0, calc.Sub(input1, input2), "Substitution of 2 strings numbers works incorrect");
        }


    }
}
