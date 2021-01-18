using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Opifex.Scim2.Core.Tests
{
    [TestClass]
    public class NameTests
    {
        [TestMethod]
        public void Formatted_ForValidFirst_ReturnsFormattedString()
        {
            // Arrange
            var expected = "Thanos";
            var testName = new Name(expected);

            // Act
            var actual = testName.Formatted;

            // Assert
            Assert.AreEqual(expected, actual, false);
        }

        [TestMethod]
        public void Formatted_ForValidFirstLast_ReturnsFormattedString()
        {
            // Arrange
            var expected = "Jack Napier";
            var testName = new Name("Jack", "Napier");

            // Act
            var actual = testName.Formatted;

            // Assert
            Assert.AreEqual(expected, actual, false);
        }

        [TestMethod]
        public void Formatted_ForValidFirstMiddleLast_ReturnsFormattedString()
        {
            // Arrange
            var expected = "Anthony Edward Stark";
            var testName = new Name("Anthony", "Edward", "Stark");

            // Act
            var actual = testName.Formatted;

            // Assert
            Assert.AreEqual(expected, actual, false);
        }

        [TestMethod]
        public void Formatted_ForValidFirstMiddleLastSuffix_ReturnsFormattedString()
        {
            // Arrange
            var expected = "Curtis James Jackson III";
            var testName = new Name("Curtis", "James", "Jackson", "III");

            // Act
            var actual = testName.Formatted;

            // Assert
            Assert.AreEqual(expected, actual, false);
        }
    }
}
