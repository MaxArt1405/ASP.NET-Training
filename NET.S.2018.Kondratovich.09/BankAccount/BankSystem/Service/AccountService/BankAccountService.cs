
using System;
using BankAccounts.Service.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Accounts.BaseAccount;

namespace BankAccounts.Service
{
    public class BankAccountService : IBankAccountService
    {
        readonly BankAccountRepository _bankAccountRepository = new BankAccountRepository();

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
            _bankAccountRepository.Add(account);
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

            _bankAccountRepository.Remove(index);
        }
        public void Deactivate(BankAccount account, Status status)
        {
            account.status = status;
        }
        public override string ToString()
        {
            string result = string.Empty;

            foreach(var item in _bankAccountRepository.Storage)
            {
                result += item + "\n";
            }

            return result;
        }

        private bool IsExists(BankAccount accountToFind)
        {
            bool result = false;

            foreach (var bankAccount in _bankAccountRepository.Storage)
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

            for (int i = 0; i < _bankAccountRepository.Storage.Count; i++)
            {
                if (_bankAccountRepository.Storage[i].Equals(accountToFind))
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
