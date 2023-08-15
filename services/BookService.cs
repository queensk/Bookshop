using System.Net.Http.Json;
using BookShop.Models.IService;
using Models;

namespace BookShop.services
{
    public class BookService : IBookShopService
    {
        private readonly HttpClient _HttpClient = new HttpClient();
        public BookService()
        {
            _HttpClient.BaseAddress = new Uri("http://localhost:3000");
        
        }
        async Task<successMessage> IBookShopService.AddBook(Book book)
        {

            var content = new StringContent(book.ToJson(), System.Text.Encoding.UTF8, "application/json");
            var response = await _HttpClient.PostAsJsonAsync("/books", content);
            if (response.IsSuccessStatusCode)
            {
                return new successMessage { message = "book added successfully"};
            }
            throw new NotImplementedException();
        }

        async Task<Book> IBookShopService.DeleteBookById(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Book>> IBookShopService.GetAllBooks()
        {
            throw new NotImplementedException();
        }

        Task<Book> IBookShopService.GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        Task<Book> IBookShopService.UpdateBookById(int id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}