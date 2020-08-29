using System;
using System.Collections.Generic;
using System.Text;

namespace Opifex.Scim2.Core.Exceptions
{
    public class LanguagePreferenceException : Exception
    {
        public LanguagePreferenceException(string message) : base(message)
        {
        }

        public LanguagePreferenceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public LanguagePreferenceException()
        {
        }
    }
}
