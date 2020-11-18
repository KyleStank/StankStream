using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using StankStream.Models.Blog;

namespace StankStream.Dal.Ef
{
    public class StankContext : DbContext
    {
        public StankContext(DbContextOptions<StankContext> options) : base(options) {}

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
