using Library.Dto;
namespace Library;
public class BookRentalDto : BookDto
{
    public MemberDto? RentedTo { get; set; }
}

