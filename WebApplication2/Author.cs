using System.ComponentModel.DataAnnotations;

namespace Library
{
    public class Author
    {
        public int Id { get; set; }
        [Required] public string? FirstName { get; set; } = null!;
        [Required] public string? LastName { get; set; }
        public int AuthorId { get; set; }
        public List<Book> Books { get; set; } = null!;
    }
}
