using System;
using System.Collections;
using System.Collections.Specialized;

namespace HybridDictExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create the hybrid dictionary
            HybridDictionary myHbd = new HybridDictionary(20, false);

            // TODO: Add some initial items
            myHbd.Add("item1", "value1");
            myHbd.Add("item2", "value2");
            myHbd.Add("item3", "value3");
            myHbd.Add("item4", "value4");
            Console.WriteLine($"Dictionary Size: {myHbd.Count}");
            

            // TODO: Contains
            Console.WriteLine(myHbd.Contains("item1"));
            

            // TODO: Remove
            myHbd.Remove("item3");
            foreach (DictionaryEntry de in myHbd) {
                Console.WriteLine($"{de.Key}, {de.Value}");
                
            }

            // TODO: Clear
            myHbd.Clear();

            // TODO: Print the number of items
            Console.WriteLine($"Dictionary Size: {myHbd.Count}");
        }
    }
}
