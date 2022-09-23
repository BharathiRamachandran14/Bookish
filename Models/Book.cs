namespace Bookish.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set;}
        public List<Author>? Author { get; set; }
        public string? CoverImageUrl { get; set; }
        public string? Blurb { get; set; }
    }
}
