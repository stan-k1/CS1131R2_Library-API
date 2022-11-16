using Library.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Library.Services
{
    public interface IBookService
    {
        Task<BookDto?> AddBook(BookDto dto);
        Task<bool> Delete(int id);
        Task<List<BookDto>> GetAllBooks();
        Task<BookDto?> GetBook(int id);
        Task<BookRentalDto?> GetRental(int bookId);
        Task<BookDto> Replace(int bookId, BookDto dto);
        Task<List<BookDto>?> Search([FromQuery] string? name, [FromQuery] string? publisher, [FromQuery] string? authorFirst, [FromQuery] string? authorLast);
        Task<BookDto> Update(int bookId, BookDto dto);
    }
}