using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class IncorrectValueException : Exception
    {
        public IncorrectValueException() : base("Введено некорректное значение")
        {
        }
        public IncorrectValueException(string message):base(message)
        {
        }
    }
}
