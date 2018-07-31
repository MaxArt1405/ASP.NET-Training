using BLL.Interfaces.Exceptions;
using System;
using System.Globalization;

namespace BLL.Interfaces.Accounts.BaseAccount
{
    public abstract class BankAccount
    {
        private string _id;
        private string _holderName;
        private decimal _balance;
        private int _bonusPoints;
        private readonly Status _status;

        public BankAccount(string id, string holderName, decimal balance, int bonusPoints, Status status)
        {
            Id = id;
            HolderName = holderName;
            Balance = balance;
            BonusPoints = bonusPoints;
            _status = status;
        }
        public string Id
        {
            get
            {
                return _id;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException($"The reference of {nameof(value)} can not be null!");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException($"The value of {nameof(value)} can not be empty");
                }

                _id = value;
            }
        }
        public string HolderName
        {
            get
            {
                return _holderName;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException($"The reference of {nameof(value)} can not be null!");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException($"The value of {nameof(value)} can not be empty");
                }

                _holderName = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return _balance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"The value of {nameof(value)}  must be greater than 0!");
                }

                _balance = value;
            }
        }
        public int BonusPoints
        {
            get
            {
                return _bonusPoints;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"The value of {nameof(value)}  must be greater than 0!");
                }

                _bonusPoints = value;
            }
        }
        public Status Status { get; set; }

        public bool Equals(BankAccount @object)
        {
            if (@object == null)
            {
                return false;
            }

            if (ReferenceEquals(this, @object))
            {
                return true;
            }

            if (GetType() != @object.GetType())
            {
                return false;
            }

            if (Id == @object.Id)
            {
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            return string.Format("Bank member: № {0}, Name: {1}, CurrentBalance: {2}, CurrentBonusPoints: {3}, Status: {4}", Id, HolderName, Balance.ToString("N", NumberFormatInfo.InvariantInfo), BonusPoints, _status); ;
        }
        public abstract BankAccountTypes Type { get; }

        public void Deposite(decimal amount)
        {
            if (amount < 0)
            {
                throw new InsufficientOfMoneyException($"The value of {nameof(amount)} is less than zero!");
            }

            Balance += amount;
            BonusPoints += CalculateBonusPoints(amount);
        }
        public void Withdraw(decimal amount)
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
        protected abstract int CalculateBonusPoints(decimal amount);
    }
}
