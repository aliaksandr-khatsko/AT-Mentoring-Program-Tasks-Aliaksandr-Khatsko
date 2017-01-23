using System;
using NUnit.Framework;

namespace NUnitPrj
{
    [TestFixture]
    public class BaseClass
    {
        [SetUp]
        public void Initialize()
        {
            Console.WriteLine("Test Initialization");
        }

        [TearDown]
        public void TestCleanup()
        {
            Console.WriteLine("CleanUp");
        }

    }
}
