using BLL.Interfaces.Accounts;
using BLL.Interfaces.Accounts.BaseAccount;
using BLL.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount2._0.Factories
{
    public class BankAccountFactory : IBankAccountFactory
    {
        public BankAccount Create(string id, string name, decimal balance, int bonusPoints, Status status, BankAccountTypes type)
        {
            switch (type)
            {
                case BankAccountTypes.Prime:
                    return new PrimeAccount(id, name, balance, bonusPoints, status);

                case BankAccountTypes.Silver:
                    return new SilverAccount(id, name, balance, bonusPoints, status);

                case BankAccountTypes.Gold:
                    return new GoldAccount(id, name, balance, bonusPoints, status);

                case BankAccountTypes.Platinum:
                    return new PlatinumAccount(id, name, balance, bonusPoints, status);

                default:
                    return new PrimeAccount(id, name, balance, bonusPoints, status);
            }
        }
    }
}
