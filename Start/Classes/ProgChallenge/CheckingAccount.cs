using System;

namespace ProgChallenge
{
    class CheckingAcct : BankAccount
    {
        public CheckingAcct(string firstName, string lastName, decimal openingBalance)
            : base (firstName, lastName, openingBalance)
        {
            OverdraftFee = 35m;
        }

        public decimal OverdraftFee {
            get;
        }

        public override decimal Withdraw(decimal withdrawalValue)
        {
            decimal accountBalance = base.Withdraw(withdrawalValue);
            if (accountBalance < 0) {
                accountBalance = base.Withdraw(OverdraftFee);
            }
            return accountBalance;
        }
    }
}
