using System.Threading.Tasks;

using StankStream.Dal.Ef;
using StankStream.Models.Blog;

namespace StankStream.Domain.Services.Blogs
{
    public interface IBlogService
    {
        Task<Blog> AddBlog(Blog model);
        Task<Blog> GetBlog(int id);
        // Task<Blog> UpdateBlog(Blog model);
        // Task<Blog> RemoveBlog(Blog model);
    }

    public class BlogService : IBlogService
    {
        private readonly StankContext _context;

        public BlogService(StankContext context)
        {
            _context = context;
        }

        public async Task<Blog> AddBlog(Blog model)
        {
            _context.Blogs.Add(model);

            await _context.SaveChangesAsync();

            return model;
        }

        public async Task<Blog> GetBlog(int id)
        {
            return await _context.Blogs.FindAsync(id);
        }

        // public async Task<Blog> UpdateBlog(Blog model)
        // {

        // }

        // public async Task<Blog> RemoveBlog(Blog model)
        // {

        // }
    }
}
