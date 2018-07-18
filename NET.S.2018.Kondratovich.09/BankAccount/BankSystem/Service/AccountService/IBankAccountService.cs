using BankAccounts.Accounts.BaseAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Service
{
    public interface IBankAccountService
    {
        void Add(BankAccount account);

        void Remove(BankAccount account);

        void Deactivate(BankAccount account, Status status);
    }
}
