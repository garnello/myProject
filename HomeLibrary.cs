﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2._10
{
    public class HomeLibrary
    {
        public List<Book> books = new List<Book>()
        {
            new Book("Bak", "Dan", 2011),
            new Book("Buk", "Din", 2021),
            new Book("Bik", "Dun", 2021),
            new Book("Byk", "Dyan", 2020),
            new Book("Bok", "Doon", 2009),
        };

        public void AddNewBook() // Добавление книги
        {
            Console.Write("\nEnter title book: ");
            string newTitleBook = Console.ReadLine();

            Console.Write("Enter name author book: ");
            string newBookAuthor = Console.ReadLine();

            Console.Write("Enter year of publication new book: ");
            int yearOfPublicationNewBook = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            books.Add(new Book(newTitleBook, newBookAuthor, yearOfPublicationNewBook));
        }

        public void RemoveBook(string titleBook) // Удаление одной книги
        {
            books.RemoveAll(b => b.BookTitle == titleBook);
        }

        public void SortBookBy() // Сортировка по...
        {
            Console.Write("\nEnter action: \n" +
                          "1. Sort on name author.\n" +
                          "2. Sort on year of publication.\n" +
                          "3. Sort on title books.\n" +
                          "Choice: ");
            int chooseSort = Convert.ToInt32(Console.ReadLine());

            switch (chooseSort)
            {
                case 1: // Сортировка по имени автора

                    var sortedBooksOnAuthor = books.OrderBy(book => book.Author);

                    foreach (var p in sortedBooksOnAuthor)
                        Console.Write($"Book: {p.BookTitle}\n" +
                                      $"Author: {p.Author}\n" +
                                      $"Year of publication: {p.YearOfPublication}\n\n");
                    break;

                case 2: // Сортировка по году издания

                    var sortedBooksOnYaer = books.OrderBy(book => book.YearOfPublication);

                    foreach (var p in sortedBooksOnYaer)
                        Console.Write($"Book: {p.BookTitle}\n" +
                                      $"Author: {p.Author}\n" +
                                      $"Year of publication: {p.YearOfPublication}\n\n");
                    break;
                case 3:
                    var sortedBooksonTitleBook = books.OrderBy(book => book.BookTitle);

                    foreach (var p in sortedBooksonTitleBook)
                        Console.Write($"Book: {p.BookTitle}\n" +
                                      $"Author: {p.Author}\n" +
                                      $"Year of publication: {p.YearOfPublication}\n\n");
                    break;

                default:
                    Console.WriteLine("Error xD");
                    break;
            }
        }

        public void SearchBy() // Поиск книг по...
        {

        }
    }
}

