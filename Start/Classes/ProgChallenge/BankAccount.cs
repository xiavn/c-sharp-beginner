using System;

namespace ProgChallenge
{
    class BankAccount
    {
        private string _firstName;
        private string _lastName;
        public BankAccount(string firstName, string lastName, decimal openingBalance) {
            _firstName = firstName;
            _lastName = lastName;
            Balance = openingBalance;
        }

        public decimal Balance {
            get;
            protected set;
        }

        public string AccountOwner {
            get => $"{_firstName} {_lastName}";
        }

        public virtual decimal Deposit(decimal depositValue) {
            if (depositValue > 0) {
                Balance += depositValue;
                return Balance;
            } else {
                throw new ArgumentOutOfRangeException("depositValue", "depositValue should be a positive value.");
            }
        }

        public virtual decimal Withdraw(decimal withdrawalValue) {
            if (withdrawalValue > 0) {
                Balance -= withdrawalValue;
                return Balance;
            } else {
                throw new ArgumentOutOfRangeException("withdrawalValue", "withdrawalValue should be a positive value.");
            }
        }
    }
}
