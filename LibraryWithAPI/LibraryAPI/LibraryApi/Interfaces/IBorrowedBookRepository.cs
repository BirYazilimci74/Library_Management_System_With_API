using LibraryApi.DTOs.BorrowedBook;
using LibraryApi.Models;

namespace LibraryApi.Interfaces
{
    public interface IBorrowedBookRepository : IGenericRepository<BorrowedBook,BorrowedBookDTO>
    {
        
    }
}