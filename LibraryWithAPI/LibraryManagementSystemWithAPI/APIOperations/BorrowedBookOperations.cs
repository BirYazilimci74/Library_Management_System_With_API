using System.Text;
using System.Text.Json;
using LibraryManagementSystemWithAPI.DTOs.BorrowedBook;
using LibraryManagementSystemWithAPI.Models;

namespace LibraryManagementSystemWithAPI.APIOperations
{
    public class BorrowedBookOperations
    {
        private readonly HttpClient _httpClient;
        private const string Url = "http://localhost:5069/api/borrowedbook";

        public BorrowedBookOperations(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<BorrowedBook>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage message = await _httpClient.GetAsync(Url);
                message.EnsureSuccessStatusCode();

                string bookJson = await message.Content.ReadAsStringAsync();
                //Console.WriteLine(bookJson);
                var bbBooks = JsonSerializer.Deserialize<List<BorrowedBook>>(bookJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return bbBooks ?? new List<BorrowedBook>();
            }
            catch
            {
                MessageBox.Show("The Books couldn't get from database!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public async Task<BorrowedBook> GetByIdAsync(int id)
        {
            try
            {
                HttpResponseMessage message = await _httpClient.GetAsync(Url + $"/{id}");
                message.EnsureSuccessStatusCode();

                string bookJson = await message.Content.ReadAsStringAsync();

                var book = JsonSerializer.Deserialize<BorrowedBook>(bookJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return book ?? new BorrowedBook();
            }
            catch
            {
                MessageBox.Show("The Book couldn't get from database!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public async Task DeleteBorrowedBookByIdAsync(int id)
        {
            try
            {
                var massage = await _httpClient.DeleteAsync(Url + $"/{id}");
            }
            catch
            {
                MessageBox.Show("The Book Couldn't Returned!!!\nDelete Issue", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public async Task AddBorrowedBookAsync(BorrowedBookDTO borrowedBookDto)
        {
            var json = JsonSerializer.Serialize(borrowedBookDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            
            try
            {
                var response = await _httpClient.PostAsync(Url, content);
            }
            catch
            {
                MessageBox.Show("The Book Couldn't Borrowed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
