using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

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
