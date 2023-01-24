﻿using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// <summary>
        /// This is the main sample application function
        /// </summary>
        /// <param name='args'>An array of string arguments from the command line</param>
        /// <returns>
        /// No return value
        /// </returns>
        static void Main(string[] args)
        {
            // Single line
            // Another single
            Console.WriteLine("Hello World!");
            /* Multi line comment
            that spans multiple lines
            over a single comment */
        }
    }
}
