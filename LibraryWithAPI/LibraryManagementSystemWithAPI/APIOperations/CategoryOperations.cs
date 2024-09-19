using LibraryManagementSystemWithAPI.Models;
using System.Text.Json;

namespace LibraryManagementSystemWithAPI.APIOperations
{
    public class CategoryOperations
    {
        private readonly HttpClient _httpClient;
        private const string Url = "http://localhost:5069/api/catagory";
        public CategoryOperations(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage message = await _httpClient.GetAsync(Url);
                message.EnsureSuccessStatusCode();

                string categoryJson = await message.Content.ReadAsStringAsync();
                //Console.WriteLine(bookJson);
                var categories = JsonSerializer.Deserialize<List<Category>>(categoryJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return categories ?? new List<Category>();
            }
            catch
            {
                MessageBox.Show("The Categories couldn't get from database!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            try
            {
                HttpResponseMessage message = await _httpClient.GetAsync(Url + $"/{id}");
                message.EnsureSuccessStatusCode();

                string categoryJson = await message.Content.ReadAsStringAsync();

                var category = JsonSerializer.Deserialize<Category>(categoryJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return category ?? new Category();
            }
            catch
            {
                MessageBox.Show("The Category couldn't get from database!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
