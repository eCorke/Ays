using Ays.Exceptions;
using System;
using System.Net;

namespace Ays
{
    /// <summary>
    /// Static exception factory/helper
    /// </summary>
    public static class E
    {
        #region Public Methods

        public static ApplicationNetException ApplicationNet(string message, Exception innerException = null, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            W.ArgumentNotEmpty(message, nameof(message));

            if (innerException == null)
            {
                return new ApplicationNetException(message, statusCode);
            }
            else
            {
                return new ApplicationNetException(message, innerException, statusCode);
            }
        }

        public static ArgumentException Argument(string message, string argumentName)
        {
            W.ArgumentNotEmpty(message, nameof(message));
            W.ArgumentNotEmpty(argumentName, nameof(argumentName));

            return new ArgumentException(message, argumentName);
        }

        public static ArgumentNullException ArgumentNull(string argumentName)
        {
            W.ArgumentNotEmpty(argumentName, nameof(argumentName));

            return new ArgumentNullException(argumentName);
        }

        public static ItemNotFoundException ItemNotFound(string message, Exception innerException = null)
        {
            W.ArgumentNotEmpty(message, nameof(message));

            if (innerException == null)
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
            W.ArgumentNotEmpty(message, nameof(message));

            if (innerException == null)
            {
                return new UnexpectedValueException(message, actualValue);
            }
            else
            {
                return new UnexpectedValueException(message, actualValue, innerException);
            }
        }

        #endregion Public Methods
    }
}