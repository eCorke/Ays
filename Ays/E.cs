using Ays.Exceptions;
using System;

namespace Ays
{
    /// <summary>
    /// Static exception factory/helper
    /// </summary>
    public static class E
    {
        public static ItemNotFoundException ItemNotFound(string message, Exception innerException)
        {
            if(innerException == null)
            {
                return new ItemNotFoundException(message);
            }
            else
            {
                return new ItemNotFoundException(message, innerException);
            }
        }

        public static UnexpectedValueException UnexpectedValue(string message, object actualValue, Exception innerException = null)
        {
            if (innerException == null)
            {
                return new UnexpectedValueException(message, actualValue);
            }
            else
            {
                return new UnexpectedValueException(message, actualValue, innerException);
            }
        }

        public static ArgumentNullException ArgumentNull(string argumentName)
        {
            W.ArgumentNotEmpty(argumentName, nameof(argumentName));

            return new ArgumentNullException(argumentName);
        }

        public static ArgumentException Argument(string message, string argumentName)
        {
            W.ArgumentNotEmpty(message, nameof(message));
            W.ArgumentNotEmpty(argumentName, nameof(argumentName));

            return new ArgumentException(message, argumentName);
        }
    }
}
