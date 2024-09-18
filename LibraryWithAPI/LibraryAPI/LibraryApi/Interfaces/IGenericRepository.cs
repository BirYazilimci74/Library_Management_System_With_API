
namespace LibraryApi.Interfaces
{
    public interface IGenericRepository<Entity,EntityRequest>
    {
        Task<List<Entity>> GetAllAsync();
        Task<Entity?> GetByIdAsync(int id);
        Task<Entity> AddAsync(EntityRequest entityRequest);
        Task<Entity?> UpdateAsync(int id,EntityRequest entityRequest);
        Task<Entity?> DeleteAsync(int id);
    }
}