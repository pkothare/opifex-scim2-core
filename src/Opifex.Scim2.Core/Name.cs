using System;
using System.Collections.Generic;
using System.Text;

namespace Opifex.Scim2.Core
{
    public class Name
    {
        public string Formatted => string.Join(' ',
                HonorificPrefix,
                GivenName,
                MiddleName,
                FamilyName,
                HonorificSuffix).Trim();

        public string FamilyName { get; }

        public string GivenName { get; }

        public string MiddleName { get; }

        public string HonorificPrefix { get; }

        public string HonorificSuffix { get; }
    }
}
