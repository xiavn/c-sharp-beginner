using System;

namespace StringRep {
    class Book {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; }

        public Book(string name, string author, int pages) {
            Name = name;
            Author = author;
            PageCount = pages;
        }

        // TODO: The ToString method generates a string represenation of the object
        public override string ToString()
        {
            return $"Book: {Name} by {Author}";
        }

        // TODO: ToString can be overloaded to give different format versions
        // Notice that this version is NOT an override function
        public string ToString(char format) {
            if (format == 'B') {
                return $"Book: {Name}:{Author}";
            }
            if (format == 'F') {
                return $"Book: {Name} by {Author}, {PageCount} pages";
            }
            return ToString();
        }
    }
}