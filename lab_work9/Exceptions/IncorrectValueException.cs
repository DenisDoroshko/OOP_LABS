using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /// <summary>
    /// Represents an input error
    /// </summary>
    
    public class IncorrectValueException : Exception
    {
        /// <summary>
        /// Creates an input error
        /// </summary>
        
        public IncorrectValueException() : base("Incorrect value")
        {
        }

        /// <summary>
        /// Creates an input error
        /// </summary>
        /// <param name="message">Inforamtion about error</param>
        
        public IncorrectValueException(string message):base(message)
        {
        }
    }
}
