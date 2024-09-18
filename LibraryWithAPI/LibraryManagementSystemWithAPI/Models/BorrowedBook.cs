using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystemWithAPI.Models
{
    public class BorrowedBook
    {
        [Key]
        public int Id { get; set; }
        public DateTime BorrewedTime { get; set; } = DateTime.Now;
        public DateTime ReturnTime { get; set; } = DateTime.Now.AddDays(15);
        public int BookID { get; set; }
        public Book? Book { get; set; }
    }
}