using System;
using System.Collections.Generic;
using System.Globalization;

namespace Opifex.Scim2.Core
{
    public class User<TKey> : Resource<TKey> where TKey : IKey
    {
        public string UserName { get; }

        public Name Name { get; set; }

        public string DisplayName { get; }

        public string NickName { get; }

        public Uri ProfileUrl { get; }

        public string Title { get; }

        public string UserType { get; }

        public LanguagePreference PreferredLanguage { get; }

        public CultureInfo Locale { get; }

        public string TimeZone { get; }

        public bool Active { get; }

        public string Password { get; set; }

        public List<EmailInfo> Emails { get; }

        public List<PhoneNumberInfo> PhoneNumbers { get; }

        public MultiValued<ImInfo> Ims { get; }

        public MultiValued<Uri> Photos { get; }

        public MultiValued<AddressInfo> Addresses { get; }

    }
}
