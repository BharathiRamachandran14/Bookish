namespace Bookish.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set;}
        public List<Author>? Authors { get; set; }
        public string? CoverImageUrl { get; set; }
        public string? Blurb { get; set; }
        public List<Member>? CheckedOutBy { get; set; }
    }
}
