using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Accounts.BaseAccount;

namespace BankAccounts.AccountBuilder
{
    public static class AccountIdGenerator
    {
        public static string GenerateAccountNumber()
        {
            int ID = 0;
            Random rnd = new Random();
            ID = rnd.Next();
            return ID.ToString();
        }
    }
}
