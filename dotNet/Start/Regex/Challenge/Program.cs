using System.Text.RegularExpressions;

bool exit = false;

static string ReverseDateFormat(string sourceDate) {
    const int TIMEOUT = 1000;
    try {
        return Regex.Replace(sourceDate,
               @"^(?<mon>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2,4})$",
              "${year}-${mon}-${day}", RegexOptions.None,
              TimeSpan.FromMilliseconds(TIMEOUT));
    }
    catch (RegexMatchTimeoutException) {
        return sourceDate;
    }
}

do {
    Console.WriteLine($"Please enter a date (mm/dd/yyyy format):");

    string input;
    input = Console.ReadLine() ?? "";

    if (input == "exit") {
        exit = true;
        break;
    }

    DateTime result;
    if (DateTime.TryParse(input, out result)) {
        Console.WriteLine($"The reveresed format is: {ReverseDateFormat(input)}");
    } else {
        Console.WriteLine("That is an invalid date.");
    }

} while (!exit);
