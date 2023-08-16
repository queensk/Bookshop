using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace BookShop.Models.IService
{
    public interface IBookShopService
    {
        Task<List<Book>> GetAllBooks();
        Task<Book> GetBookById(string id);
        Task<successMessage> UpdateBookById(string id, Book book);
        Task<successMessage> DeleteBookById(string id);
        Task<successMessage> AddBook(Book book);
    }
}
