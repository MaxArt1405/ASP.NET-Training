using BankAccounts.Accounts.BaseAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.AccountBuilder
{
    public class BankAccountBuilder
    {
        public BankAccount Create(string name, decimal balance, int bonusPoints, Status status, BankAccountTypes type)
        {
            switch (type)
            {
                case BankAccountTypes.Prime:
                    return new PrimeAccount(AccountIdGenerator.GenerateAccountNumber(), name, balance, bonusPoints, status);

                case BankAccountTypes.Silver:
                    return new SilverAccount(AccountIdGenerator.GenerateAccountNumber(), name, balance, bonusPoints, status);

                case BankAccountTypes.Gold:
                    return new GoldAccount(AccountIdGenerator.GenerateAccountNumber(), name, balance, bonusPoints, status);

                case BankAccountTypes.Platinum:
                    return new PlatinumAccount(AccountIdGenerator.GenerateAccountNumber(), name, balance, bonusPoints, status);

                default:
                    return new PrimeAccount(AccountIdGenerator.GenerateAccountNumber(), name, balance, bonusPoints, status);
            }
        }
    }
}
