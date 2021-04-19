using Microsoft.EntityFrameworkCore;
using MyBlog.DataEntities;

namespace MyBlog.Data
{
    public class MyBlogContext : DbContext
    {
        public MyBlogContext(DbContextOptions<MyBlogContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }
    }
}