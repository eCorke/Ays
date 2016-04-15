using System;
using System.Collections.Generic;
using System.Linq;

namespace Ays.Extensions
{
    public static class ExceptionExt
    {
        #region Public Methods

        /// <summary>
        /// Formats exception messages as fallowing:
        /// Exception.Message => (Exception.InnerException.Message; Exception.AnotherInnerException.Message)
        /// </summary>
        public static string GetFormattedMessage(this Exception exception)
        {
            W.ArgumentNotNull(exception, nameof(exception));

            string message = exception.Message;

            if (exception is AggregateException)
            {
                AggregateException aggregateException = ((AggregateException)exception).Flatten();

                List<string> innerExceptionMessages = new List<string>();
                foreach (Exception innerException in aggregateException.InnerExceptions)
                {
                    innerExceptionMessages.Add(GetFormattedMessage(innerException));
                }

                message = $"{message} => ({ string.Join("; ", innerExceptionMessages.Select(m => $"'{m}'")) })";
            }
            else if (exception.InnerException != null)
            {
                message = $"{message} => ({ GetFormattedMessage(exception.InnerException) })";
            }

            return message;
        }

        #endregion Public Methods
    }
}