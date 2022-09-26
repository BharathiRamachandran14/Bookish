namespace Bookish.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string? MemberName { get; set; }
        public string? Password { get; set; }
        public List<Book>? CheckedOutBooks { get; set; }
    }
}