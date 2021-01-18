using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Opifex.Scim2.Core
{
    public class LanguagePreferenceCollection : IEnumerable<LanguagePreference>
    {
        private readonly IEnumerable<LanguagePreference> _languagePreferences;

        public LanguagePreferenceCollection(string languageTagsWithQualityValues)
        {
            if (string.IsNullOrWhiteSpace(languageTagsWithQualityValues)) return;

            _languagePreferences =
                languageTagsWithQualityValues.Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => LanguagePreference.Parse(x.Trim()));
        }


        public IEnumerator<LanguagePreference> GetEnumerator() => _languagePreferences.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
