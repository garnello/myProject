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
                        library.ShowAllBooks();
                        break;

                     case 5: // Весь список
                         library.ShowAllBooks();
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
 }
