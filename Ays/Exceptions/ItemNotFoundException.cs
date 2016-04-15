using System;
using System.Collections.Generic;

namespace Ays.Exceptions
{
    /// <summary>
    /// Thrown in case of not found item detected
    /// </summary>
    public class ItemNotFoundException : KeyNotFoundException
    {

        public ItemNotFoundException(string message) : base(message)
        {

        }

        public ItemNotFoundException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
