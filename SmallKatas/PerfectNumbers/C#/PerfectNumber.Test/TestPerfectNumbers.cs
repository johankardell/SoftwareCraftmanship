using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerfectNumber.Test
{
    [TestClass]
    public class TestPerfectNumbers
    {
        [TestMethod]
        public void SixReturnsTrue()
        {
            // Arrange
            var perfectNumberCalculator = new PerfectNumberCalculator();

            // Act
            var actual = perfectNumberCalculator.IsPerfectNumber(6);

            // Assert
            Assert.IsTrue(actual, "6 is a perfect number");
        }

        [TestMethod]
        public void TenReturnsFalse()
        {
            // Arrange
            var perfectNumberCalculator = new PerfectNumberCalculator();

            // Act
            var actual = perfectNumberCalculator.IsPerfectNumber(10);

            // Assert
            Assert.IsFalse(actual, "10 is not a perfect number");
        }
    }
}
