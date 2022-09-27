namespace Bookish.Models.Requests
{
    public class BookRequest
    {
        public int Id { get; set; }
        public string? Title { get; set;}
        public List<int>? Authors { get; set; }
        public string? CoverImageUrl { get; set; }
        public string? Blurb { get; set; }
        public List<int>? CheckedOutBy { get; set; }
    }
}
