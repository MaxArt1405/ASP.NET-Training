using BankAccounts.Accounts.BaseAccount;
using BankAccounts.Exceptions;
using BankAccounts.AccountBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class PlatinumAccount : BankAccount
    {
        public PlatinumAccount(string id, string name, decimal balance, int bonusPoint, Status status) : base(id, name, balance, bonusPoint, status) { }
        public new void Deposite(decimal amount)
        {
            if (amount < 0)
            {
                throw new InsufficientOfMoneyException($"The value of {nameof(amount)} is less than zero!");
            }

            Balance += amount;
            BonusPoints += CalculateBonusPoints(amount);
        }
        public new void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new InsufficientOfMoneyException($"The value of {nameof(amount)} is less than zero!");
            }

            if (amount > Balance)
            {
                throw new InsufficientOfMoneyException($"The value of {nameof(amount)} cn not be greater than {nameof(Balance)}!");
            }

            Balance -= amount;
            BonusPoints = (BonusPoints - CalculateBonusPoints(amount)) > 0 ? (BonusPoints -= CalculateBonusPoints(amount)) : 0;
        }
        public override BankAccountTypes Type { get; } = BankAccountTypes.Platinum;
        protected override int CalculateBonusPoints(decimal amount) => (int)Math.Round((int)amount * 0.50);
    }
}
