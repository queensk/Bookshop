using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using BookShop.Models.IService;
using Models;

namespace BookShop.services
{
    public class BookService : IBookShopService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public BookService()
        {
            _httpClient.BaseAddress = new Uri("http://localhost:3000");
        }

        public async Task<successMessage> AddBook(Book book)
        {
            var json = JsonSerializer.Serialize(book);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("books", content);
            if (response.IsSuccessStatusCode)
            {
                return new successMessage { message = "Book added successfully" };
            }
            else
            {
                throw new Exception("Failed to add book.");
            }
        }

        public async Task<List<Book>> GetAllBooks()
        {
            var response = await _httpClient.GetFromJsonAsync<List<Book>>("books");
            return response ?? new List<Book>();
        }

        public async Task<Book> GetBookById(string id)
        {
            var response = await _httpClient.GetFromJsonAsync<Book>($"books/{id}");
            return response;
        }

        public async Task<successMessage> UpdateBookById(string id, Book book)
        {
            var json = JsonSerializer.Serialize(book);
            Console.WriteLine(json);
            
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"books/{id}", content);

            if (response.IsSuccessStatusCode)
            {
                 return new successMessage { message = "Book updated successfully" };
            }
            else
            {
                throw new Exception("Failed to update book.");
            }
        }

        public async Task<successMessage> DeleteBookById(string id)
        {
            var response = await _httpClient.DeleteAsync($"books/{id}");

            if (response.IsSuccessStatusCode)
            {
                return new successMessage { message = "Book deleted successfully" };
            }
            else
            {
                throw new Exception("Failed to delete book.");
            }
        }

    }
}
