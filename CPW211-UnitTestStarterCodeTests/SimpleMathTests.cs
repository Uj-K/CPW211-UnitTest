using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        [TestCategory("Add")]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            double expected = SimpleMath.Add(num1, num2);
            Assert.AreEqual(num1 + num2, expected);

        }

        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        [DataRow(1.27, -9.246548)]
        [TestCategory("Multiply")]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double expected = SimpleMath.Multiply(num1, num2);
            Assert.AreEqual(num1 * num2, expected);
        }

        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, 0)]
        [DataRow(0, -0)]
        [TestCategory("Divide")]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            if (num2 == 0)
            {
                Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(num1, num2));
                return;
            }       
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(-124, -1.0)]
        [DataRow(27.548, 3.25)]
        [TestCategory("Divide")]
        public void Divide_Method_With_TwoValidNumbers(double num1, double num2)
        {
             double expected = SimpleMath.Divide(num1, num2);
             Assert.AreEqual(num1 / num2, expected);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(-124, -1.0)]
        [DataRow(27.548, 3.25)]
        [TestCategory("Subtract")]
        public void Subtract_Method_With_TwoValidNumbers(double num1, double num2)
        {
            double expected = SimpleMath.Subtract(num1, num2);
            Assert.AreEqual(num1 - num2, expected);
        }
    }
}