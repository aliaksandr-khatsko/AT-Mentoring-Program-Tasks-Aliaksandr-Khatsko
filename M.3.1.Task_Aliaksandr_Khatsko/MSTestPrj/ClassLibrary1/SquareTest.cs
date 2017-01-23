﻿using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnitPrj
{
    class SquareTest:BaseClass
    {
        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestSquarePositiveNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(4, calc.Sqrt(2.1111), "Square method of positive numbers works incorrect");
        }

        [TearDown]
        public void CleanUpTest1()
        {
            Console.WriteLine("Test CleanUp");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestSquareZero()
        {
            var calc = new Calculator();
            Assert.AreEqual(0, calc.Sqrt(0), "Square method of zero works incorrect");
        }

        [TearDown]
        public void CleanUpTest2()
        {
            Console.WriteLine("Test CleanUp");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestSquareNegNum()
        {
            var calc = new Calculator();

            Assert.AreEqual(4, calc.Sqrt(-2.1111), "Square method of negative numbers works incorrect");
        }

        [TearDown]
        public void CleanUpTest3()
        {
            Console.WriteLine("Test CleanUp");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestSquareStr()
        {
            var calc = new Calculator();
            string input1 = "test1";
            Assert.Throws<NotFiniteNumberException>(() => calc.Sqrt(input1), "Wrong input");
        }

        [TearDown]
        public void CleanUpTest4()
        {
            Console.WriteLine("Test CleanUp");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestSquareStrNum()
        {
            var calc = new Calculator();
            string input1 = "2";
            Assert.AreEqual(4, calc.Sqrt(input1), "Square method of string numbers works incorrect");
        }

        [TearDown]
        public void CleanUpTest5()
        {
            Console.WriteLine("Test CleanUp");
        }
    }
}
