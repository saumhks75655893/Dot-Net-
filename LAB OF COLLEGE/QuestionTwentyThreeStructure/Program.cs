using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwentyThreeStructure
{
    struct Author
    {
        public string Name;
        public string Country;

        public void DisplayAuthor()
        {
            Console.WriteLine($"Author: {Name}, \nCountry: {Country}");
        }
    }

    struct Book
    {
        public string Title;
        public int Year;
        public Author WrittenBy; // Nested structure

        public void DisplayBook()
        {
            Console.WriteLine($"Book Title: {Title}, Year: {Year}");
            WrittenBy.DisplayAuthor();
        }
    }

    class Program
    {
        static void Main()
        {
            Book book;

            book.Title = "C# Basics";
            book.Year = 2023;
            book.WrittenBy.Name = "K. Ramchandran";
            book.WrittenBy.Country = "USA";

            book.DisplayBook();
        }
    }

}
