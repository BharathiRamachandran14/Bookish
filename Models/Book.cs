namespace Bookish.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set;}
        public string? Author { get; set; }
        public string? CoverImageUrl { get; set; }
        public string? Blurb { get; set; }

        // public Book(string title, string author, string coverImageUrl, string blurb)
        // {
        //     Title = title;
        //     Author = author;
        //     CoverImageUrl = coverImageUrl;
        //     Blurb = blurb;
        // }
    }
}
