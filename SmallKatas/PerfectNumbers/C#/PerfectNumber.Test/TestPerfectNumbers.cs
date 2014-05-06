using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerfectNumber.Test
{
    [TestClass]
    public class TestPerfectNumbers
    {
        [TestMethod]
        public void FourIsNotAPerfectNumber()
        {
            // Arrange
            var perfectNumberCalculator = new PerfectNumberCalculator();

            // Act
            var actual = perfectNumberCalculator.IsPerfectNumber(4);

            // Assert
            Assert.IsFalse(actual, "4 is not a perfect number");
        }

        [TestMethod]
        public void SixIsAPerfectNumber()
        {
            // Arrange
            var perfectNumberCalculator = new PerfectNumberCalculator();

            // Act
            var actual = perfectNumberCalculator.IsPerfectNumber(6);

            // Assert
            Assert.IsTrue(actual, "6 is a perfect number");
        }

        [TestMethod]
        public void TenIsNotAPerfectNumber()
        {
            // Arrange
            var perfectNumberCalculator = new PerfectNumberCalculator();

            // Act
            var actual = perfectNumberCalculator.IsPerfectNumber(10);

            // Assert
            Assert.IsFalse(actual, "10 is not a perfect number");
        }

        [TestMethod]
        public void TwentyIsNotAPerfectNumber()
        {
            // Arrange
            var perfectNumberCalculator = new PerfectNumberCalculator();

            // Act
            var actual = perfectNumberCalculator.IsPerfectNumber(20);

            // Assert
            Assert.IsFalse(actual, "20 is not a perfect number");
        }

        [TestMethod]
        public void TwentyEightIsAPerfectNumber()
        {
            // Arrange
            var perfectNumberCalculator = new PerfectNumberCalculator();

            // Act
            var actual = perfectNumberCalculator.IsPerfectNumber(28);

            // Assert
            Assert.IsTrue(actual, "28 is a perfect number");
        }

        [TestMethod]
        public void OneHundredTwelveIsNotAPerfectNumber()
        {
            // Arrange
            var perfectNumberCalculator = new PerfectNumberCalculator();

            // Act
            var actual = perfectNumberCalculator.IsPerfectNumber(112);

            // Assert
            Assert.IsFalse(actual, "112 is not a perfect number");
        }

        [TestMethod]
        public void FourhundredNinetySixIsAPerfectNumber()
        {
            // Arrange
            var perfectNumberCalculator = new PerfectNumberCalculator();

            // Act
            var actual = perfectNumberCalculator.IsPerfectNumber(496);

            // Assert
            Assert.IsTrue(actual, "496 is a perfect number");
        }

        [TestMethod]
        public void FourThousandOneHundredTwentyNineIsNotAPerfectNumber()
        {
            // Arrange
            var perfectNumberCalculator = new PerfectNumberCalculator();

            // Act
            var actual = perfectNumberCalculator.IsPerfectNumber(4129);

            // Assert
            Assert.IsFalse(actual, "4129 is not a perfect number");
        }

        [TestMethod]
        public void EightThousandOneHundredTwentyEightIsAPerfectNumber()
        {
            // Arrange
            var perfectNumberCalculator = new PerfectNumberCalculator();

            // Act
            var actual = perfectNumberCalculator.IsPerfectNumber(8128);

            // Assert
            Assert.IsTrue(actual, "8128 is a perfect number");
        }

        [TestMethod]
        public void TwelveThousandFourHundredElevenIsNotAPerfectNumber()
        {
            // Arrange
            var perfectNumberCalculator = new PerfectNumberCalculator();

            // Act
            var actual = perfectNumberCalculator.IsPerfectNumber(12411);

            // Assert
            Assert.IsFalse(actual, "12411 is not a perfect number");
        }
    }
}
