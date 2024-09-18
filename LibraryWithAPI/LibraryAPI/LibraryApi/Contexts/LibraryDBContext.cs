using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Contexts
{
    public class LibraryDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public LibraryDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}