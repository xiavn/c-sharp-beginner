using System;
using System.Collections.Generic;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty Queue that holds strings
            Queue<string> myqueue = new Queue<string>();

            // Add items to the end of the queue
            myqueue.Enqueue("one");
            myqueue.Enqueue("two");
            myqueue.Enqueue("three");
            myqueue.Enqueue("four");
            myqueue.Enqueue("five");

            // use the count property to see how many items there are
            Console.WriteLine($"Item Count: {myqueue.Count}");
            

            // Queues can be iterated without changing the structure
            foreach (string item in myqueue) {
                Console.WriteLine(item);
            }

            // peek at the front of the queue
            string front = myqueue.Peek();
            Console.WriteLine(front);
            

            // remove items from the front of the queue
            front = myqueue.Dequeue();
            Console.WriteLine($"Dequeued item is: {front}");
            front = myqueue.Dequeue();
            Console.WriteLine($"Dequeued item is: {front}");

            // see if the queue contains an item
            Console.WriteLine($"Queue contains: {myqueue.Contains("one")}");
            Console.WriteLine($"Queue contains: {myqueue.Contains("four")}");
            

            // Remove all the items
            myqueue.Clear();
            Console.WriteLine($"Item Count: {myqueue.Count}");
        }
    }
}
