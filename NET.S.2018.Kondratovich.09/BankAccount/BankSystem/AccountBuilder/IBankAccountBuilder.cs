using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.AccountBuilder
{
    public interface IBankAccountBuilder
    {
        BankAccount Create(int id, string name, decimal balance, int bonusPoints, BankAccountTypes type);
    }
}
