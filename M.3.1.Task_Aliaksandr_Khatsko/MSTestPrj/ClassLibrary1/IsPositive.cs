using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnitPrj
{
    class IsPositive:BaseClass
    {
        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestIsPositiveZero()
        {
            var calc = new Calculator();
            Assert.AreEqual(false, calc.isPositive(0), "IsPositive function works incorrect");
        }

        [TearDown]
        public void CleanUpTest1()
        {
            Console.WriteLine("Test CleanUp");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestIsPositivePosNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(true, calc.isPositive(0.1), "IsPositive function works incorrect");
        }

        [TearDown]
        public void CleanUpTest2()
        {
            Console.WriteLine("Test CleanUp");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestIsPositiveNegNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(false, calc.isPositive(-0.1), "IsPositive function works incorrect");
        }

        [TearDown]
        public void CleanUpTest3()
        {
            Console.WriteLine("Test CleanUp");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestIsPositiveStr()
        {
            var calc = new Calculator();
            string input1 = "test1";
            Assert.Throws<NotFiniteNumberException>(() => calc.isPositive(input1), "Wrong input");
        }

        [TearDown]
        public void CleanUpTest4()
        {
            Console.WriteLine("Test CleanUp");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestIsPositiveStringNum()
        {
            var calc = new Calculator();
            string input1 = "10";
            Assert.AreEqual(true, calc.isPositive(input1), "IsPositive function works incorrect");
        }

        [TearDown]
        public void CleanUpTest5()
        {
            Console.WriteLine("Test CleanUp");
        }
    }
}
