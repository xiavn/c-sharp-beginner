string curpath = "FileCollection";
string resultsFile = "results.txt";
string ppt = ".pptx";
string word = ".docx";
string excel = ".xlsx";

List<string> thefiles = new List<string>(Directory.EnumerateFiles(curpath));
long pptCount = 0;
long pptSize = 0;
long wordCount = 0;
long wordSize = 0;
long excelCount = 0;
long excelSize = 0;

foreach (string file in thefiles) {
    FileInfo fi = new FileInfo(file);
    if (fi.Extension == ppt) {
        pptCount++;
        pptSize += fi.Length;
    }
    if (fi.Extension == word) {
        wordCount++;
        wordSize += fi.Length;
    }
    if (fi.Extension == excel) {
        excelCount++;
        excelSize += fi.Length;
    }
}

using (StreamWriter sw = File.CreateText(resultsFile)) {
    sw.WriteLine("~~~~ Results ~~~~");
    sw.WriteLine($"Total Files: {pptCount + wordCount + excelCount}");
    sw.WriteLine($"Powerpoint Files: {pptCount}");
    sw.WriteLine($"Word Files: {wordCount}");
    sw.WriteLine($"Excel Files: {excelCount}");
    sw.WriteLine("----");
    sw.WriteLine($"Total Size: {(pptSize + wordSize + excelSize):N0}");
    sw.WriteLine($"Powerpoint Size: {pptSize:N0}");
    sw.WriteLine($"Word Size: {wordSize:N0}");
    sw.WriteLine($"Excel Size: {excelSize:N0}");
}
