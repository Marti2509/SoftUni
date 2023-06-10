using Microsoft.EntityFrameworkCore;

using ForumApp.Data.Models;

namespace ForumApp.Data
{
    public class ForumAppDbContext : DbContext
    {
        public ForumAppDbContext(DbContextOptions<ForumAppDbContext> options)
            :base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
