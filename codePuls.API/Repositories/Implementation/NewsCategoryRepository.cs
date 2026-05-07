using codePuls.API.Models.Domain;
using codePuls.API.Repositories.Interface;
using CodePuls.API.Data;
using Microsoft.EntityFrameworkCore;

namespace CodePuls.API.Repositories.Implementation
{
    public class NewsCategoryRepository : INewsCategory
    {
        private readonly ApplicationDbContext dbContext;

        public NewsCategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<NewsCategory> CreateAsync(NewsCategory blogPost)
        {
            await dbContext.NewsCategory.AddAsync(blogPost);
            await dbContext.SaveChangesAsync();
            return blogPost;
        }

        public async Task<NewsCategory?> DeleteAsync(Guid id)
        {
            var existingBlogPost = await dbContext.NewsCategory.FirstOrDefaultAsync(x => x.Id == id);

            if (existingBlogPost != null)
            {
                dbContext.NewsCategory.Remove(existingBlogPost);
                await dbContext.SaveChangesAsync();
                return existingBlogPost;
            }

            return null;
        }

        public async Task<IEnumerable<NewsCategory>> GetAllAsync()
        {
            return await dbContext.NewsCategory.Include(x => x.Categories).ToListAsync();
        }

        public async Task<NewsCategory?> GetByIdAsync(Guid id)
        {
            return await dbContext.NewsCategory.Include(x => x.Categories).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<NewsCategory?> GetByUrlHandleAsync(string urlHandle)
        {
            return await dbContext.NewsCategory.Include(x => x.Categories).FirstOrDefaultAsync(x => x.UrlHandle == urlHandle);
        }

        public async Task<NewsCategory?> UpdateAsync(NewsCategory blogPost)
        {
            var existingBlogPost = await dbContext.NewsCategory.Include(x => x.Categories)
                .FirstOrDefaultAsync(x => x.Id == blogPost.Id);

            if (existingBlogPost == null)
            {
                return null;
            }

            // Update entity scalar properties
            dbContext.Entry(existingBlogPost).CurrentValues.SetValues(blogPost);

            // Update navigation collection
            existingBlogPost.Categories = blogPost.Categories;

            await dbContext.SaveChangesAsync();

            return blogPost;
        }
    }
}
