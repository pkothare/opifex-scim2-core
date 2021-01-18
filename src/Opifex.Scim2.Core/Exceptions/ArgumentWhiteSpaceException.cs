using System;
using Opifex.Scim2.Core.Resources;

namespace Opifex.Scim2.Core.Exceptions
{
    public class ArgumentWhiteSpaceException : ArgumentException
    {
        public ArgumentWhiteSpaceException()
            : base(ErrorMessages.CannotBeWhiteSpace)
        {

        }

        public ArgumentWhiteSpaceException(string paramName)
            : base(ErrorMessages.CannotBeWhiteSpace, paramName)
        {

        }

        public ArgumentWhiteSpaceException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
