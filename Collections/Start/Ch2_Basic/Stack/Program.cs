using System;
using System.Collections.Generic;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create an empty stack
            Stack<string> mystack = new Stack<string>();

            // TODO: The Push function pushes new elements onto the stack
            mystack.Push("one");
            mystack.Push("two");
            mystack.Push("three");
            mystack.Push("four");
            mystack.Push("five");

            // TODO: The Count property indicates how many elements are on the stack
            Console.WriteLine($"Item Count: {mystack.Count}");
            

            // TODO: Stacks can be enumerated in place without changing the content
            foreach (string s in mystack) {
                Console.WriteLine(s);
            }

            // TODO: The Peek function examines the current top element but does not remove it
            string top = mystack.Peek();
            Console.WriteLine(top);
            

            // TODO: The Pop function removes an element from the top
            string item = mystack.Pop();
            Console.WriteLine(item);
            foreach (string s in mystack) {
                Console.WriteLine(s);
            }

            // TODO: Search for an element using Contains
            Console.WriteLine($"Item found: {mystack.Contains("five")}");
            Console.WriteLine($"Item found: {mystack.Contains("four")}");
        }
    }
}
