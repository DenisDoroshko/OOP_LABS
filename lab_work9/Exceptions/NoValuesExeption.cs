using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /// <summary>
    /// Represents a no value error
    /// </summary>

    public class NoValuesExeption : Exception
    {
        /// <summary>
        /// Creates a no value error
        /// </summary>
        
        public NoValuesExeption() : base("No values")
        {
        }

        /// <summary>
        /// Creates a no value error
        /// </summary>
        /// <param name="message">Information about error</param>
        
        public NoValuesExeption(string message) : base(message)
        {
        }
    }
}
