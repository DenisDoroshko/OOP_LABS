using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /// <summary>
    /// Represents a choice error
    /// </summary>

    public class NoChoiceException:Exception
    {
        /// <summary>
        /// Creates a choice error
        /// </summary>

        public NoChoiceException() : base("There is no choice")
        {
        }

        /// <summary>
        /// Creates a choice error
        /// </summary>
        /// <param name="message">Inforamtion about error</param>

        public NoChoiceException(string message) : base(message)
        {
        }
    }
}
