namespace Library.Dto
{
    public class BookDtoFlat
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? AuthorId { get; set; }
        public string? AuthorFirstName { get; set; }
        public string? AuthorLastName { get; set; }
        public string? Publisher { get; set; }
        public int? RenterId { get; set; }
    }

}
