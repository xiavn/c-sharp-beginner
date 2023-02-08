using System;

// Use this file to create your solution to the Lambdas challenge

namespace LambdasSolution
{
    public delegate void BalanceEventHandler(int theValue);

    class Program
    {
        static void Main(string[] args)
        {
            
            int goal = 500;
            BankAccount account = new BankAccount(goal);
            account.balanceChanged += (val) => {
                Console.WriteLine($"Your current account balance is: {val:C2}.");
            };
            account.balanceChanged += (val) => {
                if (val >= account.SavingsGoal) {
                    Console.WriteLine($"You have met your savings goal!");
                };
            };
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
    }
}