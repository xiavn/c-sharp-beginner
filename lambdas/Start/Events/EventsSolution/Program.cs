using System;

namespace EventsSolution
{

    public delegate void balanceUpdatedEventHandler(int newValue, bool metGoal);
    class Program
    {
        static void Main(string[] args)
        {
            
            int goal = 500;
            BankAccount account = new BankAccount(goal);
            account.balanceChanged += balanceChangeListener;
            do {
                Console.WriteLine($"How much would you like to deposit / withdraw? Type exit to stop.");
                string input = Console.ReadLine() ?? "";
                if (input == "exit") {
                    break;
                }
                int adjustment;
                try {
                    adjustment = int.Parse(input);
                    account.Balance += adjustment;
                } catch {
                    Console.WriteLine($"That was not a valid balance adjustment.");
                }
                
            } while (true);
        }

        static void balanceChangeListener(int newValue, bool metGoal) {
            Console.WriteLine($"Your current account balance is: {newValue:C2}.");
            if (metGoal) {
                Console.WriteLine($"You have met your savings goal!");
            }
        }
    }
}
