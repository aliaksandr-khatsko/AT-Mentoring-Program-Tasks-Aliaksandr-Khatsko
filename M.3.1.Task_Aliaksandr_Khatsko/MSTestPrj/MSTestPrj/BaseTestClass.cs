using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestPrj
{
    [TestClass]
    public class BaseTestClass
    {
        [TestInitialize]
        public void Initialize()
        {
            Console.WriteLine("Test Initialization");
        }
        
        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine("CleanUp");
        }

    }
}
