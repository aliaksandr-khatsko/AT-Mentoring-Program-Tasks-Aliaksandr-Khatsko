using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnitPrj
{
    class DivideTest:BaseClass
    {
        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestDivPositiveNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(1, calc.Divide(2.25, 2.25), "Dividing of positive and numbers works incorrect");
        }

        [TearDown]
        public void CleanUpTest1()
        {
            Console.WriteLine("Test CleanUp");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestDivPosNegNum()
        {
            var calc = new Calculator();
            Assert.AreEqual(-1, calc.Divide(-2.25, 2.25), "Dividing of positive and numbers works incorrect");
        }

        [TearDown]
        public void CleanUpTest2()
        {
            Console.WriteLine("Test CleanUp");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestDivNegNum()
        {
            var calc = new Calculator();

            Assert.AreEqual(1, calc.Divide(-2.25, -2.25), "Dividing of 2 negative numbers works incorrect");
        }

        [TearDown]
        public void CleanUpTest3()
        {
            Console.WriteLine("Test CleanUp");
        }

        [Test]
        [Author("Aliaksandr Khatsko")]
        public void TestDivideByZero()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0), "Divided by zero exception is not handled");
        }

        [TearDown]
        public void CleanUpTest4()
        {
            Console.WriteLine("Test CleanUp");
        }
    }
}
