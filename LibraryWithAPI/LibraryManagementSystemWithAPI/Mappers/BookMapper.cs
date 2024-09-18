using LibraryManagementSystemWithAPI.DTOs.Book;
using LibraryManagementSystemWithAPI.Models;

namespace LibraryManagementSystemWithAPI.Mappers
{
    public static class BookMapper
    {
        public static BookResponseDTO ToBookResponseDTO(this Book bookModel)
        {
            return new BookResponseDTO
            {
                Id = bookModel.Id,
                Name = bookModel.Name ?? string.Empty,
                Author = bookModel.Author ?? string.Empty,
                CategoryName = bookModel.Category?.Name ?? "Unknown",
                Stock = bookModel.Stock,
            };
        }

        public static Book ToBook(this BookDTO bookDTO)
        {
            return new Book
            {
                Name = bookDTO.Name,
                Author = bookDTO.Author,
                CategoryId = bookDTO.CategoryId,
                Stock = bookDTO.Stock,
            };
        }

        public static BookDTO ToBookDTO (this Book bookModel)
        {
            return new BookDTO
            {
                Name = bookModel.Name,
                Author = bookModel.Author,
                CategoryId = bookModel.CategoryId,
                Stock = bookModel.Stock,
            };
        }
    }
}