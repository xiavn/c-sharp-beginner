using System;

namespace BasicLambdas
{
    // define a few delegate types
    public delegate int MyDelegate(int x);
    public delegate void MyDelegate2(int x, string prefix);
    public delegate bool ExprDelegate(int x);

    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create a basic delegate that squares a number
            MyDelegate d1 = x => x * x;
            Console.WriteLine($"The result of d1 is {d1(5)}");
            

            // TODO: Dynamically change the delegate to something else
            d1 = x => x * 10;
            Console.WriteLine($"The result of d1 is {d1(5)}");
            // TODO: Create a delegate that takes multiple arguments
            MyDelegate2 d2 = (x, y) => Console.WriteLine($"{y}{x}");
            d2(4, "A");

            // TODO: Define an expression delegate
            ExprDelegate d3 = x => x >= 10;
            Console.WriteLine($"Calling d3 with 5 - {d3(5)}");
            Console.WriteLine($"Calling d3 with 15 - {d3(15)}");
            
        }
    }
}