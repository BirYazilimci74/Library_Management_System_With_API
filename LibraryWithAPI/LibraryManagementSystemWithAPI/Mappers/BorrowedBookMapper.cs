using LibraryManagementSystemWithAPI.DTOs.BorrowedBook;
using LibraryManagementSystemWithAPI.Models;

namespace LibraryManagementSystemWithAPI.Mappers
{
    public static class BorrowedBookMapper
    {
        public static BorrowedBookResponseDTO ToBorrowedBookResponseDTO(this BorrowedBook borrowedBook)
        {
            return new BorrowedBookResponseDTO
            {
                BookName = borrowedBook.Book?.Name ?? "Unknown Book",
                BorrewedTime = borrowedBook.BorrewedTime,
                ReturnTime = borrowedBook.ReturnTime,
            };
        }

        public static BorrowedBookDTO ToBorrowedBookDTO(this BorrowedBook borrowedBook)
        {
            return new BorrowedBookDTO
            {
                Id = borrowedBook.Id,
                BookID = borrowedBook.BookID,
                Book = borrowedBook.Book,
                BorrewedTime = borrowedBook.BorrewedTime,
                ReturnTime = borrowedBook.ReturnTime,
            };
        }

        public static BorrowedBook ToBorrowedBook(this BorrowedBookDTO borrowedBookDTO)
        {
            return new BorrowedBook
            {
                Id = borrowedBookDTO.Id,
                BookID = borrowedBookDTO.BookID,
                Book = borrowedBookDTO.Book,
                BorrewedTime = borrowedBookDTO.BorrewedTime,
                ReturnTime = borrowedBookDTO.ReturnTime,
            };
        }
    }
}