using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.AccountBuilder
{
    public class BankAccountBuilder : IBankAccountBuilder
    {
        public BankAccount Create(int id, string name, decimal balance, int bonusPoints, BankAccountTypes type)
        {
            switch (type)
            {
                case BankAccountTypes.Prime:
                    return new PrimeAccount(id, name, balance, bonusPoints);

                case BankAccountTypes.Silver:
                    return new SilverAccount(id, name, balance, bonusPoints);

                case BankAccountTypes.Gold:
                    return new GoldAccount(id, name, balance, bonusPoints);

                case BankAccountTypes.Platinum:
                    return new PlatinumAccount(id, name, balance, bonusPoints);

                default:
                    return new PrimeAccount(id, name, balance, bonusPoints);
            }
        }
    }
}
