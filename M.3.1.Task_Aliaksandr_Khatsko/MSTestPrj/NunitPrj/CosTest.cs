﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestPrj
{

    [TestClass]
    public class CosTest
    {
        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestCosPosNum()
        {
            var calc = new Calculator();
            double input = Math.PI;
            Assert.AreEqual(-1, calc.Cos(input), "Cos function works incorrect");
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestCosNegNum()
        {
            var calc = new Calculator();
            double input = -(Math.PI);
            Assert.AreEqual(-1, calc.Cos(input), "Cos function works incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException), "Cos function was inappropriately allowed to work with strings.")]
        [Owner("Aliaksandr Khatsko")]
        public void TestCosStr()
        {
            var calc = new Calculator();
            string input1 = "test3";
            calc.Cos(input1);
        }

        [TestMethod]
        [Owner("Aliaksandr Khatsko")]
        public void TestCosNumStrng()
        {
            var calc = new Calculator();
            string input1 = "90";
            double expectedResut = -0.44807361612917015236547731439964;
            Assert.AreEqual(expectedResut, calc.Cos(input1), "Cos function works incorrect");
        }
    }
}
