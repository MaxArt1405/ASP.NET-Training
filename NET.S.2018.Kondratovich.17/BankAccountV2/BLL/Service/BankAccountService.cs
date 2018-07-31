using BLL.Interfaces.Accounts.BaseAccount;
using BLL.Interfaces.Exceptions;
using BLL.Interfaces.Interfaces;
using DAL.Interfaces.Interfaces;
using DAL.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BankAccount2._0.Service
{
    public class BankAccountService : IBankAccountService
    {

        private readonly IEnumerable<BankAccount> listBankAccounts;
        private readonly IBankAccountRepository bankAccountRepository;

        public BankAccountService(BankAccountRepository bankAccountStorage)
        {
            if (bankAccountStorage is null)
            {
                throw new ArgumentNullException(nameof(bankAccountStorage));
            }
            bankAccountRepository = bankAccountStorage;
            listBankAccounts = bankAccountRepository.GetAccountList();
        }
        public void Add(BankAccount account)
        {
            if (account is null)
            {
                throw new ArgumentNullException(nameof(account));
            }

            /*if (IsExist(account))
            {
                throw new RequestForExistAccountException($"{nameof(account)} already exists");
            }*/

            bankAccountRepository.Add(account);
        }
        public IEnumerator<BankAccount> GetEnumerator()
        {
            return listBankAccounts.GetEnumerator();
        }
        public void Remove(BankAccount account)
        {
            if (account is null)
            {
                throw new ArgumentNullException(nameof(account));
            }

            if (!IsExist(account))
            {
                throw new RequestForExistAccountException($"{nameof(account)} not found");
            }

            bankAccountRepository.Delete(account.Id);
        }
        public void Save()
        {
            bankAccountRepository.Save();
        }
        public override string ToString()
        {
            string result = string.Empty;

            foreach (var item in listBankAccounts)
            {
                result += item + "\n";
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private bool IsExist(BankAccount account) => listBankAccounts.FirstOrDefault(m => m.Id == account.Id) != null;
    }
}
