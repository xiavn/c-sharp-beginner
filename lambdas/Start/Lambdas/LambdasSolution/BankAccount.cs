namespace LambdasSolution
{

    public class BankAccount {

        int _balance;

        public BankAccount(int goal, int startingBalance = 0) {
            SavingsGoal = goal;
            _balance = startingBalance;
        }
        public event BalanceEventHandler balanceChanged;

        public int SavingsGoal {
            get;
            set;
        }

        public int Balance {
            get => _balance;
            set {
                _balance = value;
                balanceChanged(Balance);
            }
        }
    }
}