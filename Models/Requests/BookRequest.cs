namespace Bookish.Models
{
    public class BookRequest
    {
        public int Id { get; set; }
        public string? Title { get; set;}
        public List<int>? Author { get; set; }
        public string? CoverImageUrl { get; set; }
        public string? Blurb { get; set; }
        public List<int>? CheckedOutBy { get; set; }
    }
}
