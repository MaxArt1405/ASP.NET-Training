
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Service
{
    public class BankAccountService : IBankAccountService
    { 
        private readonly List<BankAccount> Storage = new List<BankAccount>();
        
        public void Add(BankAccount account)
        {
            if (account is null)
            {
                throw new ArgumentNullException($"The {nameof(account)} has null reference");
            }

            if (IsExists(account))
            {
                throw new NotImplementedException($"The {nameof(account)} already exists");
            }

            Storage.Add(account);
        }

        public void Remove(BankAccount account)
        {
            if (account is null)
            {
                throw new ArgumentNullException(nameof(account));
            }

            if (!IsExists(account, out int index))
            {
                throw new NotImplementedException($"The {nameof(account)} already exists");
            }

            Storage.RemoveAt(index);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string result = string.Empty;

            foreach (var item in Storage)
            {
                result += item + "\n";
            }

            return result;
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
