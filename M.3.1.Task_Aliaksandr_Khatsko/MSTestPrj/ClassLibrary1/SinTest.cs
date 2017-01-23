using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnitPrj
{
    class SinTest:BaseClass
    {
        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestSinPosNum()
        {
            var calc = new Calculator();
            double input = Math.PI;
            Assert.AreEqual(0, calc.Sin(input), "Sin function works incorrect");
        }

        [TearDown]
        public void CleanUpTest1()
        {
            Console.WriteLine("Test CleanUp");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestSinNegNum()
        {
            var calc = new Calculator();
            double input = -(Math.PI);
            Assert.AreEqual(0, calc.Sin(input), "Sin function works incorrect");
        }

        [TearDown]
        public void CleanUpTest2()
        {
            Console.WriteLine("Test CleanUp");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestSinStr()
        {
            var calc = new Calculator();
            string input1 = "test1";
            Assert.Throws<NotFiniteNumberException>(() => calc.Sin(input1), "Wrong input");
        }

        [TearDown]
        public void CleanUpTest3()
        {
            Console.WriteLine("Test CleanUp");
        }
    }
}
