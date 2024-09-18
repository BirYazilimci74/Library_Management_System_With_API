using LibraryApi.DTOs.Book;
using LibraryApi.Models;

namespace LibraryApi.Interfaces
{
    public interface IBookRepository : IGenericRepository<Book,BookDTO>
    {
        
    }
}