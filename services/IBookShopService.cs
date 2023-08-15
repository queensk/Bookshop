using Models;
namespace BookShop.Models.IService
{
    internal interface IBookShopService
    {
        // get all books
        Task<List<Book>> GetAllBooks();

        // get book by id
        Task<Book> GetBookById(int id);

        // update book by id
        Task<Book> UpdateBookById(int id, Book book);
        
        // delete book by id
        Task<Book> DeleteBookById(int id);
        
        // create book
        Task<Book> AddBook(Book book);
    }
}