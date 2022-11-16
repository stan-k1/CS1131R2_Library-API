using System.ComponentModel.DataAnnotations;

namespace Library
{
    public class Book
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; } = null!;
        [Required] public Author Author { get; set; } = null!;
        public string? Publisher { get; set; }
        public Member? RentedTo { get; set; }
        public int? RentedToId { get; set; }
        public int AuthorId { get; set; }
    }
}
