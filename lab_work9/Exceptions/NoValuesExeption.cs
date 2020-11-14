using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class NoValuesExeption : Exception
    {
        public NoValuesExeption() : base("No values")
        {
        }
        public NoValuesExeption(string message) : base(message)
        {
        }
    }
}
