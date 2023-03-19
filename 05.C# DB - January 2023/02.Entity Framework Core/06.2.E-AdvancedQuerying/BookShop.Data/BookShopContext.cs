namespace BookShop.Data;

using BookShop.Models;

using Microsoft.EntityFrameworkCore;

public class BookShopContext : DbContext
{
    public BookShopContext()
    {
    }

    public BookShopContext(DbContextOptions options)
        :base(options)
    {
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<BookCategory> BooksCategories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=BookShop;Integrated Security=true;TrustServerCertificate=true;");
        }

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookCategory>(e =>
        {
            e.HasKey(bk => new { bk.BookId, bk.CategoryId });
        });
    }
}