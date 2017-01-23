using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestPrj
{

    [TestClass]
    public class AddTest:BaseTestClass
    {
        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestAddPositiveDoubleNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(4.5, calc.Add(2.25, 2.25), "Adding of 2 positive numbers works incorrect");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestAddPosNegDoubleNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(0, calc.Add(-2.25, 2.25), "Adding of positive and numbers works incorrect");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestAddNegDoubleNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(-4.5, calc.Add(-2.25, -2.25), "Adding of 2 negative numbers works incorrect");
        }


        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestAddCorrectStrPos()
        {
            var calc = new Calculator();
            Assert.AreEqual(4.5, calc.Add("2.25", "2.25"), "Adding of 2 string numbers works incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException), "Wrong input")]
        [Owner("Aliaksandr Khatsko")]
        public void TestAddStr()
        {
            var calc = new Calculator();
            string input1 = "test1";
            string input2 = "test2";
            calc.Add(input1, input2);
        }

     }
}
