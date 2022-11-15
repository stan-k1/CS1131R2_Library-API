namespace Library.DTO;
using System.ComponentModel.DataAnnotations;
public class BookDto
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public AuthorDto Author { get; set; }
    public string Publisher { get; set; }
    public int? RenterId { get; set; }
}
