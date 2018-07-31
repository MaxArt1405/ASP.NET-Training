using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces.Exceptions
{
    public class RequestForExistAccountException : Exception
    {
        public RequestForExistAccountException() { }

        public RequestForExistAccountException(string message) : base(message) { }

        public RequestForExistAccountException(string message, Exception innerException) : base(message, innerException) { }
    }
}
