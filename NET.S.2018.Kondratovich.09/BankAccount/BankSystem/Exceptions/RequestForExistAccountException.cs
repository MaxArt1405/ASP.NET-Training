using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Exceptions
{
    public class RequestForExistAccountException : Exception
    {
        public RequestForExistAccountException(){ }

        public RequestForExistAccountException(string message): base(message){ }

        public RequestForExistAccountException(string message, Exception innerException): base(message, innerException){ }
    }
}
