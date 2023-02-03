using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define some strings to add to the list
            string[] comedians = {"Leo Gallagher", "Rodney Dangerfield",
                                "George Carlin", "Lenny Bruce",
                                "Eddie Murphy", "Louie Anderson"};
            // TODO: Create the list
            List<string> strlist = new List<string>(10);

            // TODO: Add some elements to the list from an existing array
            strlist.AddRange(comedians);

            // TODO: Add individual items
            strlist.Add("Tina Fey");

            // TODO: Examine the Count and Capacity
            Console.WriteLine($"Count and Capacity: {strlist.Count}, {strlist.Capacity}");
            

            // TODO: Enumerate the items in the list with a foreach loop
            PrintList(strlist);

            // TODO: Access any item by its index
            Console.WriteLine($"Item value: {strlist[4]}");
            

            // TODO: Remove items from the list
            strlist.RemoveAt(2);
            strlist.Remove("Tina Fey");

            // TODO: Sort the list content
            strlist.Sort();
            PrintList(strlist);
            

            // ** Searching List Content **/

            // TODO: Determine if a list contains a given item
            Console.WriteLine(strlist.Contains("Ron Gallagher"));
            

            // TODO: The Exists function gives us a more customizable way to search
            // by using a predicate function to examine each element in the list
            bool found = strlist.Exists(x => x.Length > 15);
            Console.WriteLine($"Item found: {found}");
            

            // TODO: Use the Find function to search through items
            string item = "";
            item = strlist.Find(x => x.StartsWith("L"));
            Console.WriteLine($"Item found: {item}");
            

            // TODO: The FindAll function can find multiple items
            List<string> itemlist = strlist.FindAll(x => x.StartsWith("L"));
            PrintList(itemlist);
            

            // TODO: Use TrueForAll to see if a given condition is true for all elements
            bool result = strlist.TrueForAll(x => x.Length > 10);
            Console.WriteLine($"Result: {result}");
            
        }

        static void PrintList(List<string> theList)
        {
            foreach (string str in theList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
