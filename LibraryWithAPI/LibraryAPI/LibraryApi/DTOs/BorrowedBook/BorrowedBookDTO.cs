
namespace LibraryApi.DTOs.BorrowedBook
{
    public class BorrowedBookDTO
    {
        public int BookID { get; set; }
        public Models.Book? Book { get; set; }
        public DateTime BorrewedTime { get; set; } = DateTime.Now;
        public DateTime ReturnTime { get; set; } = DateTime.Now.AddDays(15);
    }
}