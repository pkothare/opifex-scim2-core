using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Opifex.Scim2.Core.Tests
{
    [TestClass]
    public class QualityValueTests
    {
        [DataTestMethod]
        [DataRow("0", "0")]
        [DataRow("1", "1")]
        [DataRow("0.1", "0.1")]
        [DataRow("0.12", "0.12")]
        [DataRow("0.123", "0.123")]
        [DataRow("0.1234", "0.123")]
        [DataRow("0.1235", "0.124")]
        [DataRow("0.1236", "0.124")]
        [DataRow("0.0001", "0")]
        [DataRow("0.9999", "1")]
        public void ToString_ForAllPrecisions_ReturnsMaxThreeDecimalPlaces(string value, string expectedValue)
        {
            // Arrange
            decimal decimalValue = decimal.Parse(value);
            var qValue = new QualityValue(decimalValue);
            var expected = @$"q={expectedValue}";

            // Act
            var actual = qValue.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("0.123", "0.1231", true)]
        [DataRow("0.123", "0.1234", true)]
        [DataRow("0.124", "0.1235", true)]
        [DataRow("1", "0.9999", true)]
        [DataRow("0", "0.0001", true)]
        public void OpEquals_WithUnequalHigherPrecision_ReturnsTrue(string value1, string value2, bool expected)
        {
            // Arrange
            var qValue1 = QualityValue.Parse(value1);
            var qValue2 = QualityValue.Parse(value2);

            // Act
            var actual = qValue1 == qValue2;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(1)]
        [DataRow(1F)]
        [DataRow(false)]
        [DataRow("Some string")]
        [DataRow(null)]
        public void Equals_ForNonQualityValue_ReturnsFalse(object o)
        {
            // Arrange
            var qValue1 = new QualityValue(decimal.One);

            // Act
            var actual = qValue1.Equals(o);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Equals_ForSameQualityValue_ReturnsTrue()
        {
            // Arrange
            QualityValue qValue1 = new QualityValue(decimal.One);
            object qValue2 = new QualityValue(decimal.One);

            // Act
            var actual = qValue1.Equals(qValue2);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}
