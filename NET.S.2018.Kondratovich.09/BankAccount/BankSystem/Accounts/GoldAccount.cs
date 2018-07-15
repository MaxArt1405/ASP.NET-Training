using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class GoldAccount : BankAccount
    {
        public GoldAccount(int id, string name, decimal balance, int bonusPoint) : base(id, name, balance, bonusPoint) { }
        public override void IncludeMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException(nameof(amount));
            }

            Balance = Balance + amount;
            double coefficient = (double)amount * (0.35);
            BonusPoints = BonusPoints + (int)coefficient;
        }
        public override void ExcludeMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException($"The value of {nameof(amount)} is less than zero!");
            }

            if (amount > Balance)
            {
                throw new ArgumentException($"The value of {nameof(amount)} cn not be greater than {nameof(Balance)}!");
            }

            Balance = Balance - amount;
            double coefficient = (double)amount * (0.20);
            int enBonus = BonusPoints - (int)coefficient;
            BonusPoints = enBonus > 0 ? enBonus : 0;
        }
        public override BankAccountTypes Type { get; } = BankAccountTypes.Gold;
    }
}
