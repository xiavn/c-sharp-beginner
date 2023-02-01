using System;
// See https://aka.ms/new-console-template for more information
string input;
bool running = true;

do
{
    Console.WriteLine($"Enter a date (or 'exit' to quit):");
    input = Console.ReadLine() ?? "";
    try {
        if (input == "exit") {
            running = false;
            break;
        }
        DateTime result = DateTime.Parse(input);
        DateTime today = DateTime.Today;
        
        int daysDifferent = (result.Date - today.Date).Days;
        string multiDay = daysDifferent > 1 ? "s" : "";
        if (daysDifferent == 0) {
            Console.WriteLine($"That date is today!");
        } else if (daysDifferent < 0) {
            Console.WriteLine($"That date went by {Math.Abs(daysDifferent)} day{multiDay} ago!");
        } else {
            Console.WriteLine($"That date will be in {daysDifferent} day{multiDay}!");
        }
    }
    catch {
        Console.WriteLine($"That doesn't seem to be a valid date.");
    }
    
} while (running);
