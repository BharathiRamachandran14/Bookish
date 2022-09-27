using Bookish.Models;
using Bookish.Models.Requests;
using Bookish.Repositories;

namespace Bookish.Services
{
    public class BookService
    {
        private readonly BookRepo _books;

        public BookService()
        {
            _books = new BookRepo();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _books.GetAllBooks();
        }

        public Book Create(BookRequest newBookRequest)
        {
            return _books.Create(newBookRequest);
        }
    }
}