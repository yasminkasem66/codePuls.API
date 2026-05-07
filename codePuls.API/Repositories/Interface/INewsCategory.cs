using codePuls.API.Models.Domain;

namespace codePuls.API.Repositories.Interface
{
    public interface INewsCategory
    {
        Task<NewsCategory> CreateAsync(NewsCategory blogPost);

        Task<IEnumerable<NewsCategory>> GetAllAsync();

        Task<NewsCategory?> GetByIdAsync(Guid id);

        Task<NewsCategory?> GetByUrlHandleAsync(string urlHandle);

        Task<NewsCategory?> UpdateAsync(NewsCategory blogPost);

        Task<NewsCategory?> DeleteAsync(Guid id);
    }
}
