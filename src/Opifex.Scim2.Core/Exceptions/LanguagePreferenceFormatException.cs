using System;
using Opifex.Scim2.Core.Resources;

namespace Opifex.Scim2.Core.Exceptions
{
    public class LanguagePreferenceFormatException : FormatException
    {
        public LanguagePreferenceFormatException()
            : base(ErrorMessages.InvalidLanguagePreferenceFormat)
        {

        }

        public LanguagePreferenceFormatException(string paramName)
            : base($@"{ErrorMessages.InvalidLanguagePreferenceFormat} ({ErrorMessages.Parameter} '{paramName}')")
        {

        }

        public LanguagePreferenceFormatException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
