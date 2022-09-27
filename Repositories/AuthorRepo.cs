using Bookish.Models;
using Microsoft.EntityFrameworkCore;


namespace Bookish.Repositories
{
    public class AuthorRepo
    {
        private readonly BookishContext? _context;

        public AuthorRepo()
        {
            _context = new BookishContext();
        }


        public IEnumerable<Author> GetAllAuthors()
        {
            return _context.Authors
            .Include(a => a.Books); 
        }

        
    }
}