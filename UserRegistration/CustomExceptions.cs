using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class CustomExceptions : Exception
    {
        public string message;

        public enum ExceptionType
        {
            NULL_STRING, EMPTY_STRING, INVALID_STRING, NO_SUCH_CLASS, NO_SUCH_METHOD
        }

        public ExceptionType type;

        public CustomExceptions(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
