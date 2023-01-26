using System.Text;

// See https://aka.ms/new-console-template for more information
static bool IsAPalindrome(string inputStr) {
    string stripped = RemovePunctuationAndWhiteSpace(inputStr);
    string reversed = string.Join("", stripped.ToCharArray().Reverse());
    return stripped == reversed;
}

static string RemovePunctuationAndWhiteSpace(string inputStr) {
    StringBuilder newString = new StringBuilder();
    foreach (char c in inputStr) {
        if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c)) {
            newString.Append(char.ToLower(c));
        }
    }
    return newString.ToString();
}

static (bool status, int strLength) IsPalindrome(string inputStr) {
    bool isPal = IsAPalindrome(inputStr);
    if (isPal) {
        return (true, inputStr.Length);
    }
    return (false, 0);
}

bool keepRunning = true;

do {
    Console.WriteLine("Let's begin, type a phrase or word, or exit to quit:");
    string inputStr = Console.ReadLine();
    if (inputStr == "exit") {
        keepRunning = false;
    } else {
        var testedStr = IsPalindrome(inputStr);
        Console.WriteLine($"Palindrome: {testedStr.status}, Length: {testedStr.strLength}");
    }
} while (keepRunning);