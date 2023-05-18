using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Laba_2._10
{
    public class Book
    {
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public int YearOfPublication { get; set; }

        public Book(string BookTitle, string Author, int YearOfPublication)
        {
            this.BookTitle = BookTitle;
            this.Author = Author;
            this.YearOfPublication = YearOfPublication;
        }

        public void ShowAllBooks()
        {
            Console.WriteLine("All books in the library:");

            Console.Write($"\nTitle book: {BookTitle}" +
                          $"\nAuthor:{Author}" +
                          $"\nYear of publication:  {YearOfPublication}");
            Console.WriteLine("\n");
        }
    }
}
