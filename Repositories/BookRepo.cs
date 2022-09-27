using Bookish.Models;
using Microsoft.EntityFrameworkCore;


namespace Bookish.Repositories
{
    public class BookRepo
    {
        private readonly BookishContext? _context;


        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books
            .Include(b => b.Author); 
        }

        public Book Create(Book newBook)
        {
            Book createNewBook = new Book
            {
                Title = newBook.Title,
                Blurb = newBook.Blurb,
                CoverImageUrl = newBook.CoverImageUrl,
            };
            
            var addedEntity = _context.Books.Add(createNewBook);
            _context.SaveChanges();

            return addedEntity.Entity;
        }
    }
}