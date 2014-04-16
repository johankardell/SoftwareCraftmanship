using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumbers.Test
{
    [TestClass]
    public class TestRomanNumbers
    {
        [TestMethod]
        public void OneReturnsI()
        {
            // Arrange
            var romanNumberConverter = new RomanNumberConverter();

            // Act
            var actual = romanNumberConverter.Convert(1);

            // Assert
            Assert.AreEqual("I", actual, "1 should be translated to I");
        }

        [TestMethod]
        public void TwoReturnsII()
        {
            // Arrange
            var romanNumberConverter = new RomanNumberConverter();

            // Act
            var actual = romanNumberConverter.Convert(2);

            // Assert
            Assert.AreEqual("II", actual, "2 should be translated to II");
        }

        [TestMethod]
        public void FourReturnsIV()
        {
            // Arrange
            var romanNumberConverter = new RomanNumberConverter();

            // Act
            var actual = romanNumberConverter.Convert(4);

            // Assert
            Assert.AreEqual("IV", actual, "4 should be translated to IV");
        }

        [TestMethod]
        public void FiveReturnsV()
        {
            // Arrange
            var romanNumberConverter = new RomanNumberConverter();

            // Act
            var actual = romanNumberConverter.Convert(5);

            // Assert
            Assert.AreEqual("V", actual, "5 should be translated to V");
        }

        [TestMethod]
        public void SixReturnsVI()
        {
            // Arrange
            var romanNumberConverter = new RomanNumberConverter();

            // Act
            var actual = romanNumberConverter.Convert(6);

            // Assert
            Assert.AreEqual("VI", actual, "6 should be translated to VI");
        }


        [TestMethod]
        public void NineReturnsIX()
        {
            // Arrange
            var romanNumberConverter = new RomanNumberConverter();

            // Act
            var actual = romanNumberConverter.Convert(9);

            // Assert
            Assert.AreEqual("IX", actual, "9 should be translated to IX");
        }

        [TestMethod]
        public void TenReturnsX()
        {
            // Arrange
            var romanNumberConverter = new RomanNumberConverter();

            // Act
            var actual = romanNumberConverter.Convert(10);

            // Assert
            Assert.AreEqual("X", actual, "10 should be translated to X");
        }
    }
}
