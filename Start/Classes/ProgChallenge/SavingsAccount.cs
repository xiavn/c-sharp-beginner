using System;

namespace ProgChallenge
{
    class SavingsAcct : BankAccount
    {
        public SavingsAcct(string firstName, string lastName, decimal interestValue, decimal openingBalance)
            : base (firstName, lastName, openingBalance)
        {
            Interest = interestValue;
            FreeWithdrawalRemaining = 3;
            WithdrawalCharge = 2m;
        }

        public decimal Interest {
            get;
        }

        public int FreeWithdrawalRemaining {
            get;
            private set;
        }

        public decimal WithdrawalCharge {
            get;
        }

        public virtual void ApplyInterest() {
            Balance += (Balance * Interest);
        }

        public override decimal Withdraw(decimal withdrawalValue)
        {
            bool freeWithdrawal = FreeWithdrawalRemaining > 0;
            decimal amountToWithdraw = freeWithdrawal ? withdrawalValue : withdrawalValue + WithdrawalCharge;
            if (amountToWithdraw > Balance) {
                Console.WriteLine($"Cannot withdraw {withdrawalValue:C2}, balance remaining is {Balance:C2}");
            } else {
                decimal newBalance = base.Withdraw(amountToWithdraw);
                if (freeWithdrawal) {
                    FreeWithdrawalRemaining--;
                }
                return newBalance;
            }
            return Balance;
        }
    }
}
