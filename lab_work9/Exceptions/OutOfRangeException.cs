using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class OutOfRangeException:Exception
    {
        public OutOfRangeException() : base("Index out of range")
        {
        }
        public OutOfRangeException(string message) : base(message)
        {
        }
    }
}
