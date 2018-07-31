using BLL.Interfaces.Accounts.BaseAccount;
using BLL.Interfaces.Exceptions;
using System;

namespace BLL.Interfaces.Accounts
{
    public class GoldAccount : BankAccount
    {
        public GoldAccount(string id, string name, decimal balance, int bonusPoint, Status status) : base(id, name, balance, bonusPoint, status) { }
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
        public override BankAccountTypes Type { get; } = BankAccountTypes.Gold;
        protected override int CalculateBonusPoints(decimal amount) => (int)Math.Round((int)amount * 0.35);
    }
}
