using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookShop.Models.IService;
using BookShop.services;
using BookShop.Views;
using Models;

namespace BookShop.controller
{
    public class BookshopController
    {
        private readonly IBookShopService _bookService;
        private readonly BookshopView _view;

        public BookshopController(IBookShopService bookService, BookshopView view)
        {
            _bookService = bookService;
            _view = view;
        }

        public async Task InitApplication()
        {
            bool running = true;

            while (running)
            {
                _view.DisplayMenu();
                string choice = _view.GetUserChoice();

                switch (choice)
                {
                    case "1":
                        await AddBookAsync();
                        break;
                    case "2":
                        await ListAllBooksAsync();
                        break;
                    case "3":
                        await ViewBookDetailsAsync();
                        break;
                    case "4":
                        await UpdateBookAsync();
                        break;
                    case "5":
                        await DeleteBookAsync();
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        _view.DisplayMessage("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private async Task AddBookAsync()
        {
            _view.DisplayMessage("Enter book details:");
            Book book = _view.GetBookInput();
            successMessage result = await _bookService.AddBook(book);
            _view.DisplayMessage(result.message);
        }

        private async Task ListAllBooksAsync()
        {
            List<Book> books = await _bookService.GetAllBooks();
            _view.DisplayBooks(books);
        }

        private async Task ViewBookDetailsAsync()
        {
            string id = _view.GetBookIdInput();
            Book book = await _bookService.GetBookById(id);

            if (book != null)
            {
                _view.DisplayBookDetails(book);
            }
            else
            {
                _view.DisplayMessage("Book not found.");
            }
        }

        private async Task UpdateBookAsync()
        {
            _view.DisplayMessage("Enter book ID: ");
            string id = Console.ReadLine();

            Book book = await _bookService.GetBookById(id);

            if (book != null)
            {
                _view.DisplayMessage("Enter updated book details:");
                Book updatedBook = _view.GetBookInput();
                Console.WriteLine(updatedBook.Title);

                successMessage result = await _bookService.UpdateBookById(id, updatedBook);

                if (result != null)
                {
                    _view.DisplayMessage($"Book with ID {id} updated successfully.");
                }
                else
                {
                    _view.DisplayMessage("Failed to update book.");
                }
            }
            else
            {
                _view.DisplayMessage("Book not found.");
            }
        }


        private async Task DeleteBookAsync()
        {
            string id = _view.GetBookIdInput();
            Book bookToDelete = await _bookService.GetBookById(id);

            if (bookToDelete != null)
            {
                successMessage result = await _bookService.DeleteBookById(id);
                _view.DisplayMessage(result.message);
            }
            else
            {
                _view.DisplayMessage("Book not found.");
            }
        }
    }
}
