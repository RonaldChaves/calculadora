using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void CalculateAddTest()
        {
            double result = Calculator.Calculate(1, 1, 1);
            Assert.AreEqual(result, 2);
        }

        [TestMethod()]
        public void CalculateSubTest()
        {
            double result = Calculator.Calculate(1, 1, 2);
            Assert.AreEqual(result, 0);
        }

        [TestMethod()]
        public void CalculateDivTest()
        {
            double result = Calculator.Calculate(1, 1, 3);
            Assert.AreEqual(result, 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void CalculateDivByZeroTest()
        {
            _ = Calculator.Calculate(1, 0, 3);
        }

        [TestMethod()]
        public void CalculateMutTest()
        {
            double result = Calculator.Calculate(1, 1, 4);
            Assert.AreEqual(result, 1);
        }
    }
}