using System.Text;
using System.Text.Json;
using LibraryManagementSystemWithAPI.DTOs.Book;
using LibraryManagementSystemWithAPI.Mappers;
using LibraryManagementSystemWithAPI.Models;

namespace LibraryManagementSystemWithAPI.API
{
    public class BookOperations
    {
        private readonly HttpClient _httpClient;
        private const string Url = "http://localhost:5069/api/book";
        public BookOperations(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<Book>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage message = await _httpClient.GetAsync(Url);
                message.EnsureSuccessStatusCode();

                string bookJson = await message.Content.ReadAsStringAsync();
                //Console.WriteLine(bookJson);
                var books = JsonSerializer.Deserialize<List<Book>>(bookJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return books;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            try
            {
                var message = await _httpClient.GetAsync(Url + $"/{id}");
                message.EnsureSuccessStatusCode();

                string bookJson = await message.Content.ReadAsStringAsync();

                var book = JsonSerializer.Deserialize<Book>(bookJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return book;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task UpdateAsync(int id,BookDTO bookDto)
        {
            var json = JsonSerializer.Serialize(bookDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage response = await _httpClient.PutAsync(Url + $"/{id}", content);
                response.EnsureSuccessStatusCode();
            }
            catch
            {
                MessageBox.Show("The Book Couldn't Updated!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public async Task DeleteById(int id)
        {
            try
            {
                var message = await _httpClient.DeleteAsync(Url + $"/{id}");
                message.EnsureSuccessStatusCode();
            }
            catch
            {
                MessageBox.Show("The Book Couldn't Deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public async Task AddAsync(BookDTO bookDto)
        {
            var json = JsonSerializer.Serialize(bookDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await _httpClient.PostAsync(Url, content);
            }
            catch
            {
                MessageBox.Show("The Book Couldn't Added!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public async Task BorrowSelectedBookById(int id)
        {
            var bookToBorrow = await GetByIdAsync(id);
            bookToBorrow.Stock--;
            await UpdateAsync(id, bookToBorrow.ToBookDTO());
        }
    }
}
