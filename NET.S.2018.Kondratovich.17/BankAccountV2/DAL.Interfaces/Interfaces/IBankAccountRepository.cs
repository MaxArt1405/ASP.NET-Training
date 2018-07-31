using BLL.Interfaces.Accounts.BaseAccount;
using DAL.Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces.Interfaces
{
    public interface IBankAccountRepository
    {
        IEnumerable<BankAccount> GetAccountList();
        BankAccount GetAccountById(string id);
        void Add(BankAccount item);
        void Update(BankAccount item);
        void Delete(string id);
        void Save();
    }
}
