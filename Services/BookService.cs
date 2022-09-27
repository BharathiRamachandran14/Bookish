using Bookish.Models;
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

        public Book Create(Book newBook)
        {
            return _books.Create(newBook);
        }
    }
}