namespace Bookish.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string? MemberName { get; set; }
        public List<string>? CheckedOutBooks { get; set; }
    }
}