using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Reflection.Metadata.BlobBuilder;

namespace Laba_2._10
{
    public class Program
    {
        static void Main()
        {
            HomeLibrary library = new HomeLibrary();

            for (int i = 0; i >= 0; i++)
            {
                Console.Write("Enter action: \n" +
                          "1. Add new book.\n" +
                          "2. Remove one book.\n" +
                          "3. Sort book by ...\n" +
                          "4. Search by ...\n" +
                          "5. Show all books.\n" +
                          "6. Exit.\n" +
                          "Choice: ");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1: // Добавление новой книги
                        library.AddNewBook();
                        break;

                    case 2: // Удаление одной книги
                        Console.Write("Enter title of the book you want delete: ");
                        string deleteBook = Console.ReadLine();
                        library.RemoveBook(deleteBook);
                        break;

                    case 3: // Выбор сортировки книг
                        library.SortBookBy();
                        break;

                    case 4: // Поиск книги по автору или году издания

                        /*foreach (var p in Library)
                        {
                            Console.Write($"\n"
                                + p.BookTitle + ", "
                                + p.Author + ", "
                                + p.YearOfPublication);
                        }
                        Console.Write("\n");

                        Console.Write("\nEnter action:\n" +
                            "1. Find on title book.\n" +
                            "2. Find on name author.\n" +
                            "3. Find on year of publication.\n" +
                            "Choice: ");
                        int choiceFind = Convert.ToInt32(Console.ReadLine());

                            switch (choiceFind)
                            {
                                case 1: // Поиск по названию книги

                                    Console.Write("Enter your title books: ");
                                    string findTitle = Console.ReadLine();

                                    var findBookOnTitle = from book in Library
                                                          where book.BookTitle == findTitle
                                                          select book;
                                    foreach (var book in findBookOnTitle) Console.Write($"\n" +
                                                                                        $"Title: {book.BookTitle}\n" +
                                                                                        $"Author: {book.Author}\n" +
                                                                                        $"Year of publication: {book.YearOfPublication}. \n\n");
                                    break;

                                case 2: // Поиск по автору книги

                                    Console.Write("Enter name author: ");
                                    string findAuthor = Console.ReadLine();

                                    var findBookOnAuthor = from book in Library
                                                           where book.Author == findAuthor
                                                           select book;
                                    foreach (var book in findBookOnAuthor) Console.Write($"\n" +
                                                                                         $"Title: {book.BookTitle}\n" +
                                                                                         $"Author: {book.Author}\n" +
                                                                                         $"Year of publication: {book.YearOfPublication}. \n\n");
                                    break;

                                case 3: // Поиск по дате издания

                                    Console.Write("Enter year of publication: ");
                                    int findYear = Convert.ToInt32(Console.ReadLine());

                                    var findBookOnYear = from book in Library
                                                         where book.YearOfPublication == findYear
                                                         select book;
                                    foreach (var book in findBookOnYear) Console.Write($"\n" +
                                                                                       $"Title: {book.BookTitle}\n" +
                                                                                       $"Author: {book.Author}\n" +
                                                                                       $"Year of publication: {book.YearOfPublication}. \n\n");
                                    break;

                                default:
                                    Console.WriteLine("Error xD");
                                    break;
                            }*/
                        break;

                    case 5: // Весь список
                        foreach (Book book in HomeLibrary.books)
                            book.ShowAllBooks();
                        break;

                    case 6: // Выход
                        return;
                        break;

                    default:
                        Console.WriteLine("Error xD");
                        break;
                
            }
        }
    }

}