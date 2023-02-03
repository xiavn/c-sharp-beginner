using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionaries map keys to values. Keys must be unique
            Dictionary<string, string> fileTypes = new Dictionary<string, string>();

            // add some keys and values to the dictionary
            fileTypes.Add(".bmp", "Bitmap File");
            fileTypes.Add(".txt", "Text File");
            fileTypes.Add(".html", "HTML Document");
            fileTypes.Add(".jpg", "JPEG Image");

            // use the Count property to see how many items there are
            Console.WriteLine($"Count: {fileTypes.Count}");
            

            // Trying to add an existing key will throw an exception
            // fileTypes.Add(".txt", "Just plain text");

            // The TryAdd function makes it convenient to see if there's a duplicate
            bool added = fileTypes.TryAdd(".txt", "Just plain text");
            Console.WriteLine(added);
            

            // Dictionaries are also like associative arrays
            Console.WriteLine($"Key value: {fileTypes[".html"]}");
            
            // This way, setting an existing key just overwrites the value
            fileTypes[".html"] = "Web Page";
            Console.WriteLine($"Key value: {fileTypes[".html"]}");

            // See if the Dictionary contains an key or a value
            Console.WriteLine($"Contains key: {fileTypes.ContainsKey(".bmp")}");
            Console.WriteLine($"Contains value: {fileTypes.ContainsValue("HTML Document")}");
            

            // Remove items
            fileTypes.Remove(".bmp");
            Console.WriteLine($"Contains key: {fileTypes.ContainsKey(".bmp")}");
        }
    }
}
