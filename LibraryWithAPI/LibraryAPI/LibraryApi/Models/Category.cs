using System.ComponentModel.DataAnnotations;

namespace LibraryApi.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        List<Book> Books { get; set; } = new List<Book>();
    }
}