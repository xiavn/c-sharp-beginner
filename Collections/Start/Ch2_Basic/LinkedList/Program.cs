﻿using System;
using System.Collections.Generic;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define some strings that represent song names
            string[] songs = {"Shout", "Satisfaction", "Help!",
                            "Stairway to Heaven", "Come Sail Away",
                            "All Night Long", "Right Here Right Now"};

            // TODO: Create a LinkedList that holds strings
            LinkedList<string> mylist = new LinkedList<string>(songs);

            // TODO: Items can be added at the front or back of the list
            mylist.AddFirst("Africa");
            mylist.AddLast("The Twist");

            // TODO: Like other collections, a LinkedList can be iterated
            foreach (string song in mylist) {
                Console.WriteLine($"{song}");
            }

            // TODO: First and Last properties return LinkedListNodes
            LinkedListNode<string> first = mylist.First;
            LinkedListNode<string> last = mylist.Last;
            Console.WriteLine($"{first.Value}");
            Console.WriteLine($"{last.Value}");
            

            // TODO: Items can be added or removed relative to an existing item
            mylist.AddAfter(first, "Hello");
            foreach (string song in mylist) {
                Console.WriteLine($"{song}");
            }

            // TODO: Search for items in the list with Contains and Find
            Console.WriteLine(mylist.Contains("Satisfaction"));
            Console.WriteLine(mylist.Find("Help!").Value);
            

            // TODO: The list can then be traversed with those properties
            Console.WriteLine(first.Next.Value);
            Console.WriteLine(last.Previous.Value);
            
        }
    }
}
