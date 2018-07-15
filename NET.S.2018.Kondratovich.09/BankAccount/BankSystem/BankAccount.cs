using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public abstract class BankAccount
    {
        private int _id;
        private string _holderName;
        private decimal _balance;
        private int _bonusPoints;

        public BankAccount(int id, string holderName, decimal balance, int bonusPoints)
        {
            Id = id;
            HolderName = holderName;
            Balance = balance;
            BonusPoints = bonusPoints;
        }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"The value of {nameof(value)}  must be greater than 0!");
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
            return string.Format("Bank member: №{0}, Name: {1}, CurrentBalance: {2}, CurrentBonusPoints: {3}", Id, HolderName, Balance.ToString("N", NumberFormatInfo.InvariantInfo), BonusPoints); ;
        }
        public abstract BankAccountTypes Type { get; }

        public virtual void IncludeMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException(nameof(amount));
            }

            Balance = Balance + amount;
            double coefficient = (double)amount * (0.15);
            BonusPoints = BonusPoints + (int)coefficient;
        }
        public virtual void ExcludeMoney(decimal amount)
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
            double coefficient = (double)amount * (0.10);
            int enBonus = BonusPoints - (int)coefficient;
            BonusPoints = enBonus > 0 ? enBonus : 0;
        }
    }
}