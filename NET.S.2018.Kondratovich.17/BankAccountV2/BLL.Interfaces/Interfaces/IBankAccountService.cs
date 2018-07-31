using BLL.Interfaces.Accounts.BaseAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces.Interfaces
{
    public interface IBankAccountService : IEnumerable<BankAccount>
    {
        void Add(BankAccount account);

        void Remove(BankAccount account);

        void Save();
    }
}
