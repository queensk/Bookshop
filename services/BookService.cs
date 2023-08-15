using BookShop.Models.IService;
using Models;

namespace BookShop
{
    public class BookService : IBookShopService
    {
        private readonly HttpClient _HttpClient = new HttpClient();
        public BookService()
        {
            _HttpClient.BaseAddress = new Uri("http://localhost:3000");
        
        }
        Task<Book> IBookShopService.AddBook(Book book)
        {

            throw new NotImplementedException();
        }

        Task<Book> IBookShopService.DeleteBookById(int id)
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