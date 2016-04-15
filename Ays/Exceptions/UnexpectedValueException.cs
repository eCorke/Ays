using System;

namespace Ays.Exceptions
{
    /// <summary>
    /// Thrown in case of unexpected value passed through application
    /// </summary>
    public class UnexpectedValueException : ApplicationException
    {
        #region Public Constructors

        public UnexpectedValueException(string message, object actualValue) : base(message)
        {
            ActualValue = actualValue;
        }

        public UnexpectedValueException(string message, object actualValue, Exception innerException) : base(message, innerException)
        {
            ActualValue = actualValue;
        }

        #endregion Public Constructors

        #region Public Properties

        public object ActualValue { get; }

        #endregion Public Properties
    }
}