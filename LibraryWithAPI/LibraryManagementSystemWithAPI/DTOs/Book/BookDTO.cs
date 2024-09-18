
namespace LibraryManagementSystemWithAPI.DTOs.Book
{
    public class BookDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int? CategoryId { get; set; }
        public int Stock { get; set; }
    }
}