namespace Opifex.Scim2.Core
{
    public class AddressInfo
    {
        public string StreetAddress { get; }

        public string Locality { get; }

        public string Region { get; }

        public string PostalCode { get; }

        public string Country { get; }

        public string Formatted { get; }

        public string Type { get; }

        public bool Primary { get; }
    }
}
