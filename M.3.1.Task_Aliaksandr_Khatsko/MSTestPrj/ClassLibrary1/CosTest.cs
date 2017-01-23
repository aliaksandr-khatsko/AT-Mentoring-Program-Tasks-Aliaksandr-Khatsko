using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnitPrj
{
    class CosTest:BaseClass
    {
        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestCosPosNum()
        {
            var calc = new Calculator();
            double input = Math.PI;
            Assert.AreEqual(-1, calc.Cos(input), "Cos function works incorrect");
        }

        [TearDown]
        public void CleanUpTest1()
        {
            Console.WriteLine("Test CleanUp");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestCosNegNum()
        {
            var calc = new Calculator();
            double input = -(Math.PI);
            Assert.AreEqual(-1, calc.Cos(input), "Cos function works incorrect");
        }

        [TearDown]
        public void CleanUpTest2()
        {
            Console.WriteLine("Test CleanUp");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestCosStr()
        {
            var calc = new Calculator();
            string input1 = "test3";
            Assert.Throws<NotFiniteNumberException>(() => calc.Cos(input1), "Wrong input");
        }

        [TearDown]
        public void CleanUpTest3()
        {
            Console.WriteLine("Test CleanUp");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestCosNumStrng()
        {
            var calc = new Calculator();
            string input1 = "90";
            double expectedResut = -0.44807361612917015236547731439964;
            Assert.AreEqual(expectedResut, calc.Cos(input1), "Cos function works incorrect");
        }

        [TearDown]
        public void CleanUpTest4()
        {
            Console.WriteLine("Test CleanUp");
        }
    }
}
