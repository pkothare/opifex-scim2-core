using System;
using Opifex.Scim2.Core.Resources;

namespace Opifex.Scim2.Core.Exceptions
{
    public class QualityValueFormatException : FormatException
    {
        public QualityValueFormatException()
            : base(ErrorMessages.InvalidQualityValueFormat)
        {

        }

        public QualityValueFormatException(string paramName)
            : base($@"{ErrorMessages.InvalidQualityValueFormat} ({ErrorMessages.Parameter} '{paramName}')")
        {

        }

        public QualityValueFormatException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
