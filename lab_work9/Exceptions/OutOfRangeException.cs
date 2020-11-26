using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /// <summary>
    /// Represents an out of range error
    /// </summary>

    public class OutOfRangeException:Exception
    {
        /// <summary>
        /// Creates an out of range error
        /// </summary>
        
        public OutOfRangeException() : base("Index out of range")
        {
        }

        /// <summary>
        /// Creates an out of range error
        /// </summary>
        /// <param name="message">Inforamtion about error</param>

        public OutOfRangeException(string message) : base(message)
        {
        }
    }
}
