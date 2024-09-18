
namespace LibraryApi.DTOs.Book
{
    public class BookResponseDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public int Stock { get; set; }
    }
}