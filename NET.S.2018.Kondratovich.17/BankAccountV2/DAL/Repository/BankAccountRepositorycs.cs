using BLL.Interfaces.Accounts.BaseAccount;
using DAL.Interfaces.DTO;
using DAL.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class BankAccountRepository : IBankAccountRepository
    {
        private List<BankAccount> Storage;
        public BankAccountRepository() { Storage = new List<BankAccount>(); }

        public void Add(BankAccount item) => Storage.Add(item);
        public void Delete(string id)
        {
            BankAccount account = Storage.Find(x => x.Id.Contains(id));
            Storage.Remove(account);
        }
        public IEnumerable<BankAccount> GetAccountList()
        {
            return Storage;
        }
        public BankAccount GetAccountById(string id)
        {
            BankAccount account = Storage.Find(x => x.Id.Contains(id));
            return account;
        }
        public void Save()
        {

        }
        public void Update(BankAccount item)
        {
            
        }
    }
}
