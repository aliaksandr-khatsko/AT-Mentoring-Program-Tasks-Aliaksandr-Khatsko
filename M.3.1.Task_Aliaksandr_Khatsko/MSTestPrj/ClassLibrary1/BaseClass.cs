using System;
using NUnit.Framework;

namespace NUnitPrj
{
    public class BaseClass
    {
        [SetUp]
        public void Initialize()
        {
            Console.WriteLine("Test Initialization");
        }
    }
}
