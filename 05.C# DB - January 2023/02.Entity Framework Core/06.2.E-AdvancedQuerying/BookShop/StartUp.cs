namespace BookShop;

using BookShop.Data;
using BookShop.Initialializer;
using BookShop.Models;
using BookShop.Models.Enums;

using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text;

public class StartUp
{
    static void Main(string[] args)
    {
        using BookShopContext context = new BookShopContext();
        DbInitializer.ResetDatabase(context);

        //string result = GetBooksByAgeRestriction(context, Console.ReadLine());
        //string result = GetGoldenBooks(context);
        //string result = GetBooksByPrice(context);
        //string result = GetBooksNotReleasedIn(context, int.Parse(Console.ReadLine()));
        //string result = GetBooksByCategory(context, Console.ReadLine());
        //string result = GetBooksReleasedBefore(context, Console.ReadLine());
        //string result = GetAuthorNamesEndingIn(context, Console.ReadLine());
        //string result = GetBookTitlesContaining(context, Console.ReadLine());
        //string result = GetBooksByAuthor(context, Console.ReadLine());
        //int result = CountBooks(context, int.Parse(Console.ReadLine()));
        //string result = CountCopiesByAuthor(context);
        //string result = GetTotalProfitByCategory(context);
        //string result = GetMostRecentBooks(context);
        //IncreasePrices(context);
        int result = RemoveBooks(context);

        Console.WriteLine(result);
    }

    // Problem 2
    public static string GetBooksByAgeRestriction(BookShopContext context, string command)
    {
        StringBuilder sb = new StringBuilder();

        var books = context.Books
            .AsNoTracking()
            .Where(b => b.AgeRestriction == Enum.Parse<AgeRestriction>(command, true))
            .Select(b => b.Title)
            .OrderBy(b => b)
            .ToArray();

        foreach (var book in books)
        {
            sb.AppendLine(book);
        }

        return sb.ToString().Trim();
    }

    // Problem 3
    public static string GetGoldenBooks(BookShopContext context)
    {
        StringBuilder sb = new StringBuilder();

        var books = context.Books
            .AsNoTracking()
            .Where(b => b.EditionType == Enum.Parse<EditionType>("Gold"))
            .Where(b => b.Copies < 5000)
            .OrderBy(b => b.BookId)
            .Select(b => b.Title)
            .ToArray();

        foreach (var book in books)
        {
            sb.AppendLine(book);
        }

        return sb.ToString().Trim();
    }

    // Problem 4
    public static string GetBooksByPrice(BookShopContext context)
    {
        StringBuilder sb = new StringBuilder();

        var books = context.Books
            .AsNoTracking()
            .Where(b => b.Price > 40)
            .Select(b => new
            {
                b.Title,
                b.Price
            })
            .OrderByDescending(b => b.Price)
            .ToArray();

        foreach (var book in books)
        {
            sb.AppendLine($"{book.Title} - ${book.Price:F2}");
        }

        return sb.ToString().Trim();
    }

    // Problem 5
    public static string GetBooksNotReleasedIn(BookShopContext context, int year)
    {
        StringBuilder sb = new StringBuilder();

        var books = context.Books
            .AsNoTracking()
            .Where(b => b.ReleaseDate.HasValue == true && b.ReleaseDate.Value.Year != year)
            .OrderBy(b => b.BookId)
            .Select(b => b.Title)
            .ToArray();

        foreach (var book in books)
        {
            sb.AppendLine(book);
        }

        return sb.ToString().Trim();
    }

    // Problem 6
    public static string GetBooksByCategory(BookShopContext context, string input)
    {
        StringBuilder sb = new StringBuilder();

        var categories = input
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(b => b.ToLower())
            .ToArray();

        var books = context.Books
            .AsNoTracking()
            .Where(b => b.BookCategories.Any(bc => categories.Contains(bc.Category.Name.ToLower())))
            .OrderBy(b => b.Title)
            .Select(b => b.Title)
            .ToArray();

        foreach (var book in books)
        {
            sb.AppendLine(book);
        }

        return sb.ToString().Trim();
    }

    // Problem 7
    public static string GetBooksReleasedBefore(BookShopContext context, string date)
    {
        StringBuilder sb = new StringBuilder();

        int[] dateArr = date
            .Split("-")
            .Select(int.Parse)
            .ToArray();

        DateTime dateToCompare = new DateTime(dateArr[2], dateArr[1], dateArr[0]);

        var books = context.Books
            .AsNoTracking()
            .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value.CompareTo(dateToCompare) < 0)
            .OrderByDescending(b => b.ReleaseDate.Value)
            .Select(b => new
            {
                b.Title,
                EditionType = b.EditionType.ToString(),
                b.Price
            })
            .ToArray();

        foreach (var book in books)
        {
            sb.AppendLine($"{book.Title} - {book.EditionType} - {book.Price:F2}");
        }

        return sb.ToString().TrimEnd();
    }

    // Problem 8
    public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
    {
        StringBuilder sb = new StringBuilder();

        var authors = context.Authors
            .AsNoTracking()
            .Where(a => a.FirstName.EndsWith(input))
            .OrderBy(a => a.FirstName)
            .ThenBy(a => a.LastName)
            .Select(a => new
            {
                a.FirstName,
                a.LastName
            })
            .ToArray();

        foreach (var author in authors)
        {
            sb.AppendLine($"{author.FirstName} {author.LastName}");
        }

        return sb.ToString().Trim();
    }

    // Problem 9
    public static string GetBookTitlesContaining(BookShopContext context, string input)
    {
        StringBuilder sb = new StringBuilder();

        var books = context.Books
            .AsNoTracking()
            .Where(b => b.Title.ToLower().Contains(input.ToLower()))
            .Select(b => b.Title)
            .OrderBy(b => b)
            .ToArray();

        foreach (var book in books)
        {
            sb.AppendLine(book);
        }

        return sb.ToString().Trim();
    }

    // Problem 10
    public static string GetBooksByAuthor(BookShopContext context, string input)
    {
        StringBuilder sb = new StringBuilder();

        var books = context.Books
            .AsNoTracking()
            .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
            .OrderBy(b => b.BookId)
            .Select(b => new
            {
                b.Title,
                b.Author.FirstName,
                b.Author.LastName
            })
            .ToArray();

        foreach (var book in books)
        {
            sb.AppendLine($"{book.Title} ({book.FirstName} {book.LastName})");
        }
        
        return sb.ToString().Trim();
    }

    // Problem 11
    public static int CountBooks(BookShopContext context, int lengthCheck)
    {
        return context.Books
            .AsNoTracking()
            .Where(b => b.Title.Length > lengthCheck)
            .Count();
    }

    // Problem 12
    public static string CountCopiesByAuthor(BookShopContext context)
    {
        StringBuilder sb = new StringBuilder();

        var authors = context.Authors
            .AsNoTracking()
            .Select(a => new
            {
                Name = $"{a.FirstName} {a.LastName}",
                Copies = a.Books.Sum(b => b.Copies)
            })
            .OrderByDescending(b => b.Copies)
            .ToArray();

        foreach (var author in authors)
        {
            sb.AppendLine($"{author.Name} - {author.Copies}");
        }

        return sb.ToString().Trim();
    }

    // Problem 13
    public static string GetTotalProfitByCategory(BookShopContext context)
    {
        StringBuilder sb = new StringBuilder();

        var categories = context.Categories
            .AsNoTracking()
            .Select (c => new
            {
                c.Name,
                Price = c.CategoryBooks.Sum(cb => cb.Book.Price * cb.Book.Copies)
            })
            .OrderByDescending(c => c.Price)
            .ThenBy(c => c.Name)
            .ToArray();

        foreach (var category in categories)
        {
            sb.AppendLine($"{category.Name} ${category.Price:F2}");
        }

        return sb.ToString().Trim();
    }

    // Problem 14
    public static string GetMostRecentBooks(BookShopContext context)
    {
        StringBuilder sb = new StringBuilder();

        var categories = context.Categories
            .AsNoTracking()
            .Select(c => new
            {
                c.Name,
                TopThreeBooks = c.CategoryBooks
                .OrderByDescending(cb => cb.Book.ReleaseDate)
                .Take(3)
                .Select(cb => new
                {
                    cb.Book.Title,
                    cb.Book.ReleaseDate
                })
            })
            .OrderBy(c => c.Name)
            .ToArray();

        foreach (var category in categories)
        {
            sb.AppendLine($"--{category.Name}");

            foreach (var book in category.TopThreeBooks)
            {
                sb.AppendLine($"{book.Title} ({book.ReleaseDate.Value.Year})");
            }
        }

        return sb.ToString().Trim();
    }

    // Problem 15
    public static void IncreasePrices(BookShopContext context)
    {
        var books = context.Books
            .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value.Year < 2010)
            .ToArray();

        foreach (var book in books)
        {
            book.Price = book.Price + 5;
        }
    }

    // Problem 16
    public static int RemoveBooks(BookShopContext context)
    {
        var books = context.Books
            .Where(b => b.Copies < 4200)
            .ToArray();

        context.RemoveRange(books);

        int affectedRows = context.SaveChanges();

        return affectedRows / 2;
    }
}