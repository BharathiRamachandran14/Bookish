using Bookish.Models;
using Bookish.Repositories;

namespace Bookish.Services
{
    public class AuthorService
    {
        private readonly AuthorRepo _authors;

        public AuthorService()
        {
            _authors = new AuthorRepo();
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return _authors.GetAllAuthors();
        }
    }
}