using LibraryApi.Contexts;
using LibraryApi.DTOs.Book;
using LibraryApi.Interfaces;
using LibraryApi.Mappers;
using LibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDBContext _context;

        public BookRepository(LibraryDBContext context)
        {
            _context = context;
        }

        public async Task<Book> AddAsync(BookDTO book)
        {
            var bookModel = book.ToBook();
            await _context.Books.AddAsync(bookModel);
            await _context.SaveChangesAsync();
            
            return bookModel;
        }

        public async Task<Book?> DeleteAsync(int id)
        {
            var bookToDelete = await _context.Books.FirstOrDefaultAsync(x => x.Id == id);
            
            if (bookToDelete == null)
            {
                return null;
            }

            _context.Books.Remove(bookToDelete);
            await _context.SaveChangesAsync();
            
            return bookToDelete;
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await _context.Books.Include(b => b.Category).ToListAsync();
        }

        public async Task<Book?> GetByIdAsync(int id)
        {
            return await _context.Books.Include(b => b.Category).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book?> UpdateAsync(int id, BookDTO book)
        {
            var bookToUpdate = await _context.Books.FindAsync(id);

            if (bookToUpdate is null)
            {
                return null;
            }
            bookToUpdate.Name = book.Name;
            bookToUpdate.Author = book.Author;
            bookToUpdate.CategoryId = book.CategoryId;
            bookToUpdate.Stock = book.Stock;
            
            await _context.SaveChangesAsync();
            return bookToUpdate;
        }
    }
}