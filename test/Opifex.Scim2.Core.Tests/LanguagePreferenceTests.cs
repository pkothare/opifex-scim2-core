using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opifex.Scim2.Core.Exceptions;

namespace Opifex.Scim2.Core.Tests
{
    [TestClass]
    public class LanguagePreferenceTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Null values not handled.")]
        public void Ctor_ForNull_ThrowsException()
        {
            // Arrange
            // Nothing to arrange.

            // Act
            new LanguagePreference(null);

            // Assert is taken care of ExpectedException           
        }

        [DataTestMethod]
        [DataRow("*")]
        [DataRow("da")]
        [DataRow("en-US")]
        [DataRow("kk-KZ")]
        [DataRow("az-Latn-AZ")]
        [DataRow("bs-Cyrl-BA")]
        [DataRow("smn-FI")]
        [DataRow("en-029")]
        public void Ctor_ForValidLanguage_SetsLanguageProperty(string expected)
        {
            // Arrange
            // Nothing to arrange.

            // Act
            var languagePreference = new LanguagePreference(expected);

            // Assert
            Assert.AreEqual(expected, languagePreference.Language);
        }

        [DataTestMethod]
        [DataRow("da", 0.1)]
        [DataRow("de", 0.3)]
        [DataRow("el", 0.999)]
        [DataRow("en", 0)]
        [DataRow("fr", 1)]
        [DataRow("it", 0.499)]
        public void Ctor_ForValidLanguageAndQuality_SetsLanguageAndQualityProperties(string expectedLanguage, double quality)
        {
            // Arrange
            var expectedQuality = new QualityValue(quality);

            // Act
            var languagePreference = new LanguagePreference(expectedLanguage, expectedQuality);

            // Assert
            Assert.AreEqual(expectedLanguage, languagePreference.Language);
            Assert.AreEqual(expectedQuality, languagePreference.Quality);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Null values not handled.")]
        public void Parse_ForNull_ThrowsException()
        {
            // Arrange
            // Nothing to arrange.

            // Act
            LanguagePreference.Parse(null);

            // Assert is taken care of ExpectedException           
        }

        [DataTestMethod]
        [DataRow(" ")]
        [DataRow("")]
        [DataRow("\t \r\n")]
        [DataRow("   \r\n")]
        [ExpectedException(typeof(ArgumentWhiteSpaceException), "White space values not handled.")]
        public void Parse_ForWhiteSpace_ThrowsException(string tag)
        {
            // Arrange
            // Nothing to arrange.

            // Act
            LanguagePreference.Parse(tag);

            // Assert is taken care of ExpectedException
        }


        [ExpectedException(typeof(LanguagePreferenceFormatException), "Semicolon split not being handled correctly")]
        public void Parse_ForValidValues_(string tag)
        {
            // Arrange
            // Nothing to arrange.

            // Act
            LanguagePreference.Parse(tag);

            // Assert is taken care of ExpectedException
        }
    }
}
