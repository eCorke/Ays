using System;
using System.Net;

namespace Ays.Exceptions
{
    /// <summary>
    /// Thrown by net or net used parts of application
    /// </summary>
    public class ApplicationNetException : Exception
    {
        #region Public Constructors

        public ApplicationNetException(string message, HttpStatusCode status = HttpStatusCode.OK) : base(message)
        {
            Status = status;
        }

        public ApplicationNetException(string message, Exception innerException, HttpStatusCode status = HttpStatusCode.OK) : base(message, innerException)
        {
            Status = status;
        }

        #endregion Public Constructors

        #region Public Properties

        public HttpStatusCode Status { get; }

        #endregion Public Properties
    }
}