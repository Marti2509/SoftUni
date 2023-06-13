using Library.Core.Contracts;
using Library.Core.Models;
using Library.Data;
using Library.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Core.Services
{
    public class BookService : IBookService
    {
        private readonly LibraryDbContext dbContext;

        public BookService(LibraryDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<List<AllBookViewModel>> GetAllBooksAsync()
        {
            return await dbContext.Books
                .Select(b => new AllBookViewModel()
                {
                    Id = b.Id,
                    Title = b.Title,
                    Category = b.Category.Name,
                    Author = b.Author,
                    ImageUrl = b.ImageUrl,
                    Rating = b.Rating,
                })
                .ToListAsync();
        }

        public async Task<List<MyBookViewModel>> GetMyBooksAsync(string id)
        {
            return await dbContext.IdentityUserBooks
                .Where(u => u.CollectorId == id)
                .Select(u => new MyBookViewModel()
                {
                    Id = u.BookId,
                    Title = u.Book.Title,
                    Author = u.Book.Author,
                    Category = u.Book.Category.Name,
                    Description = u.Book.Description,
                    ImageUrl = u.Book.ImageUrl
                })
                .ToListAsync();
        }

        public async Task<AddBookFormModel> GetNewBookFormModelAsync()
        {
            var categories = await dbContext.Categories
                .Select(c => new CategoryViewModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();

            return new AddBookFormModel()
            {
                Categories = categories
            };
        }

        public async Task AddBookAsync(AddBookFormModel model)
        {
            var book = new Book()
            {
                Title = model.Title,
                Author = model.Author,
                Description = model.Description,
                CategoryId = model.CategoryId,
                ImageUrl = model.Url,
                Rating = decimal.Parse(model.Rating),
            };

            await dbContext.Books.AddAsync(book);
            await dbContext.SaveChangesAsync();
        }

        public async Task<BookViewModel?> GetBookByIdAsync(int id)
        {
            return await dbContext.Books
                .Where(b => b.Id == id)
                .Select(b => new BookViewModel()
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author,
                    Description = b.Description,
                    CategoryId = b.CategoryId,
                    ImageUrl = b.ImageUrl,
                    Rating = b.Rating
                })
                .FirstOrDefaultAsync();
        }

        public async Task AddToCollectionAsync(string id, BookViewModel book)
        {
            bool added = await dbContext.IdentityUserBooks
                .AnyAsync(u => u.CollectorId == id && u.BookId == book.Id);

            if (!added)
            {
                var userBook = new IdentityUserBook()
                {
                    CollectorId = id,
                    BookId = book.Id,
                };

                await dbContext.IdentityUserBooks.AddAsync(userBook);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task RemoveFromCollectionAsync(string id, BookViewModel book)
        {
            bool has = await dbContext.IdentityUserBooks
                .AnyAsync(u => u.CollectorId == id && u.BookId == book.Id);

            if (has)
            {
                var userBook = await dbContext.IdentityUserBooks
                    .Where(u => u.CollectorId == id && u.BookId == book.Id)
                    .FirstAsync();

                dbContext.IdentityUserBooks.Remove(userBook);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
