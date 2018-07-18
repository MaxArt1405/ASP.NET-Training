using BankAccounts.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Service.Repository
{
    public class BankAccountRepository
    {
        public List<BankAccount> Storage;
        public BankAccountRepository() { Storage = new List<BankAccount>(); }

        public void GetById(string ID) { }
        public void Add(BankAccount account)
        {    
                if (account is null)
                {
                    throw new ArgumentNullException($"The {nameof(account)} has null reference");
                }

                if (IsExists(account))
                {
                    throw new RequestForExistAccountException($"The {nameof(account)} already exists");
                }
                Storage.Add(account);      
        }
        public void Remove(int index)
        {
            Storage.RemoveAt(index);
        }
        public void Remove(string ID, BankAccount account)
        {
            if (account is null)
            {
                throw new ArgumentNullException(nameof(account));
            }

            if (!IsExists(account, out int index))
            {
                throw new RequestForExistAccountException($"The {nameof(account)} already exists");
            }

            Storage.RemoveAt(index);
        }

        private bool IsExists(BankAccount accountToFind)
        {
            bool result = false;

            foreach (var bankAccount in Storage)
            {
                if (bankAccount.Equals(accountToFind))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        private bool IsExists(BankAccount accountToFind, out int index)
        {
            bool result = false;
            index = -1;

            for (int i = 0; i < Storage.Count; i++)
            {
                if (Storage[i].Equals(accountToFind))
                {
                    result = true;
                    index = i;
                    break;
                }
            }
            return result;
        }
    }
}
