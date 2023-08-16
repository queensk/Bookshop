using System;
using System.Collections.Generic;
using Models;

namespace BookShop.Views
{
    public class BookshopView
    {
        public void DisplayMenu()
        {
            Console.WriteLine("BookShop Application");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. List All Books");
            Console.WriteLine("3. View Book Details");
            Console.WriteLine("4. Update Book");
            Console.WriteLine("5. Delete Book");
            Console.WriteLine("6. Exit");
        }

        public string GetUserChoice()
        {
            Console.Write("Enter your choice: ");
            return Console.ReadLine();
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public Book GetBookInput()
        {
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author: ");
            string author = Console.ReadLine();

            Console.Write("Enter Pages: ");
            int pages = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Language: ");
            string language = Console.ReadLine();

            return new Book(title, author, pages, language);
        }

        public string GetBookIdInput()
        {
            Console.Write("Enter Book ID: ");
            return Console.ReadLine();
        }

        public void DisplayBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }
        }

        public void DisplayBookDetails(Book book)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Pages: {book.Pages}, Language: {book.Language}");
        }
    }
}
