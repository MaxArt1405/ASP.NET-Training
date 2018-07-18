using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Exceptions
{
    public class InsufficientOfMoneyException : Exception
    {
        public InsufficientOfMoneyException() { }
        public InsufficientOfMoneyException(string message): base(message) { }
    }
}
