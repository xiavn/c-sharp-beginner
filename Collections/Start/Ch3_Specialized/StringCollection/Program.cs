using System;
using System.Collections.Specialized;

namespace StrCollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // define an initial set of strings
            string[] colors = {"red","orange","yellow","green","blue","violet"};

            // TODO: create the string collection
            StringCollection strcol = new StringCollection();

            // TODO: Add an existing set of strings
            strcol.AddRange(colors);

            // TODO: add some individual items
            strcol.Add("black");
            strcol.Insert(0, "white");

            // TODO: Use the Count property to see how many there are
            Console.WriteLine($"There are {strcol.Count} colours:");
            

            // TODO: Iterate over each string in the collection
            foreach (string color in strcol) {
                Console.Write($"{color} ");
            }
            Console.WriteLine($"");
            Console.WriteLine($"--------");
            
            
            // TODO: Access an individual item
            Console.WriteLine($"Item at 3: {strcol[3]}");
            

            // TODO: Search for a string
            System.Console.WriteLine($"Collection contains 'blue': {strcol.Contains("blue")}");
            System.Console.WriteLine($"Green is at location: {strcol.IndexOf("green")}");

            // TODO: Clear all the contents
            strcol.Clear();
            Console.WriteLine($"There are {strcol.Count} colours:");
        }
    }
}
