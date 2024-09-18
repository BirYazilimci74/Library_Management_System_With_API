using LibraryApi.Contexts;
using LibraryApi.DTOs.BorrowedBook;
using LibraryApi.Interfaces;
using LibraryApi.Mappers;
using LibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Repository
{
    public class BorrowedBookRepository : IBorrowedBookRepository
    {
        private readonly LibraryDBContext _context;

        public BorrowedBookRepository(LibraryDBContext context)
        {
            _context = context;
        }
        public async Task<BorrowedBook> AddAsync(BorrowedBookDTO borrowedBook)
        {
            await _context.BorrowedBooks.AddAsync(borrowedBook.ToBorrowedBook());
            await _context.SaveChangesAsync();
            
            return borrowedBook.ToBorrowedBook();
        }

        public async Task<BorrowedBook?> DeleteAsync(int id)
        {
            var borrowedBookToDelete = await _context.BorrowedBooks.FindAsync(id);
            
            if (borrowedBookToDelete == null)
            {
                return null;
            }

            _context.BorrowedBooks.Remove(borrowedBookToDelete);
            await _context.SaveChangesAsync();
            
            return borrowedBookToDelete;
        }

        public async Task<List<BorrowedBook>> GetAllAsync()
        {
            return await _context.BorrowedBooks.Include(bb => bb.Book).ToListAsync();
        }

        public async Task<BorrowedBook?> GetByIdAsync(int id)
        {
            return await _context.BorrowedBooks.Include(bb => bb.Book).FirstOrDefaultAsync(bb => bb.Id == id);
        }

        public async Task<BorrowedBook?> UpdateAsync(int id, BorrowedBookDTO book)
        {
            var borrowedBookToUpdate = await _context.BorrowedBooks.FindAsync(id);
            if(borrowedBookToUpdate is null)
            {
                return null;
            }
            
            borrowedBookToUpdate.ReturnTime = book.ReturnTime;
            borrowedBookToUpdate.BorrewedTime = book.BorrewedTime;
            borrowedBookToUpdate.BookID = book.BookID;
            await _context.SaveChangesAsync();
            
            return borrowedBookToUpdate;
        }
    }
}