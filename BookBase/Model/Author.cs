namespace BookBase.Model
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Firstname { get; set; } = String.Empty;
        public string Lastname { get; set; } = String.Empty;
        public ICollection<Book> Books { get; set; }
    }
}
