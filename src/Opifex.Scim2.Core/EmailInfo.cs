using System.Net.Mail;

namespace Opifex.Scim2.Core
{
    public class EmailInfo : MailAddress
    {
        public EmailInfo(string address)
            : base(address)
        {

        }

        public string Type { get; }

        public bool Primary { get; }
    }
}
