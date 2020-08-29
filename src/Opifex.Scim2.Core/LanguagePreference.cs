using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Opifex.Scim2.Core.Exceptions;

namespace Opifex.Scim2.Core
{
    public class LanguagePreference
    {

        private static readonly IEnumerable<string> _allCultures =
            CultureInfo.GetCultures(CultureTypes.AllCultures)
            .Select(c => c.Name);

        public string Language { get; }

        public QualityValue? Quality { get; }

        public LanguagePreference(string language)
        {
            if (null == language)
            {
                throw new ArgumentNullException(nameof(language));
            }
            if (string.IsNullOrWhiteSpace(language))
            {
                throw new ArgumentWhiteSpaceException(nameof(language));
            }
            language = language.Trim();
            if (language.Equals("*", StringComparison.InvariantCultureIgnoreCase))
            {
                Language = "*";
            }
            else if(!_allCultures.Contains(language, StringComparer.InvariantCultureIgnoreCase))
            {
                throw new LanguagePreferenceException();
            }
            Language = language.Trim();
        }

        public LanguagePreference(string language, QualityValue quality)
            : this(language)
        {
            Quality = quality;
        }

        public static LanguagePreference Parse(string value)
        {
            if (null == value)
            {
                throw new ArgumentNullException(nameof(value));
            }
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentWhiteSpaceException(nameof(value));
            }

            var components = value.Split(';');
            if (components.Length < 1 || components.Length > 2)
            {
                throw new LanguagePreferenceFormatException(nameof(value));
            }
            else if (components.Length == 1)
            {
                return new LanguagePreference(components[0]);
            }
            else
            {
                return new LanguagePreference(components[0], QualityValue.Parse(components[1]));
            }
        }

        public override string ToString() => Quality.HasValue
            ? $@"{Language};{Quality}"
            : Language;
    }
}
