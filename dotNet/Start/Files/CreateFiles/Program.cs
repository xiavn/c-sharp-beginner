// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Files

const string filename = "TestFile.txt";

// TODO: Create a new file - this will overwrite any existing file
// Use the "using" construct to automatically close the file stream
// using(StreamWriter sw = File.CreateText(filename)) {
//     sw.WriteLine("This is a text file");
// }

// TODO: Determine if a file exists
bool fileExists = File.Exists(filename);
Console.WriteLine(fileExists);
if (fileExists) {
    File.Delete(filename);
}
else {
    using(StreamWriter sw = File.CreateText(filename)) {
        sw.WriteLine("This is a text file");
    }   
}
Console.WriteLine(File.Exists(filename));
