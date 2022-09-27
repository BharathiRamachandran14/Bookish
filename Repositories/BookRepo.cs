using Bookish.Models;
using Bookish.Models.Requests;
using Microsoft.EntityFrameworkCore;


namespace Bookish.Repositories
{
    public class BookRepo
    {
        private readonly BookishContext? _context;

        public BookRepo()
        {
            _context = new BookishContext();
        }


        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books
            .Include(b => b.Authors); 
        }

        public Book Create(BookRequest newBookRequest)
        {
            List<Author> authors = _context
                .Authors
                .Where(a => newBookRequest.Authors.Contains(a.Id))
                .ToList();
          
            Book createNewBook = new Book
            {
                Title = newBookRequest.Title,
                Authors = authors,
                Blurb = newBookRequest.Blurb,
                CoverImageUrl = newBookRequest.CoverImageUrl,
            };
            
            var addedEntity = _context.Books.Add(createNewBook);
            _context.SaveChanges();

            return addedEntity.Entity;
        }
    }
}