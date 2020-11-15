using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class NoChoiceException:Exception
    {
        public NoChoiceException() : base("There is no choice")
        {
        }
        public NoChoiceException(string message) : base(message)
        {
        }
    }
}
