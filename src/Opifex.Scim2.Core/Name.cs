using System.Collections.Generic;

namespace Opifex.Scim2.Core
{
    public class Name
    {
        public Name(string givenName)
            : this(givenName, null)
        {

        }

        public Name(string givenName, string familyName)
            : this(givenName, null, familyName)
        {

        }

        public Name(string givenName, string middleName, string familyName)
            : this(givenName, middleName, familyName, null)
        {

        }

        public Name(string givenName,
            string middleName,
            string familyName,
            string honorificSuffix)
            : this(null, givenName, middleName, familyName, honorificSuffix)
        {

        }

        public Name(string honorificPrefix,
            string givenName,
            string middleName,
            string familyName,
            string honorificSuffix)
        {
            HonorificPrefix = honorificPrefix;
            GivenName = givenName;
            MiddleName = middleName;
            FamilyName = familyName;
            HonorificSuffix = honorificSuffix;
        }


        public string FamilyName { get; }

        public string GivenName { get; }

        public string MiddleName { get; }

        public string HonorificPrefix { get; }

        public string HonorificSuffix { get; }

        public string Formatted => string.Join(' ', FormattableComponents).Trim();

        private IEnumerable<string> FormattableComponents
        {
            get
            {
                var items = new List<string>();
                if (!string.IsNullOrWhiteSpace(HonorificPrefix))
                {
                    items.Add(HonorificPrefix);
                }
                if (!string.IsNullOrWhiteSpace(GivenName))
                {
                    items.Add(GivenName);
                }
                if (!string.IsNullOrWhiteSpace(MiddleName))
                {
                    items.Add(MiddleName);
                }
                if (!string.IsNullOrWhiteSpace(FamilyName))
                {
                    items.Add(FamilyName);
                }
                if (!string.IsNullOrWhiteSpace(HonorificSuffix))
                {
                    items.Add(HonorificSuffix);
                }
                return items;
            }
        }
    }
}
