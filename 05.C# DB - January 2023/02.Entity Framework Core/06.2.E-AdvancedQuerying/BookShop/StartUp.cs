namespace BookShop;

using BookShop.Data;
using BookShop.Initialializer;
using BookShop.Models.Enums;

using Microsoft.EntityFrameworkCore;
using System.Text;

public class StartUp
{
    static void Main(string[] args)
    {
        using BookShopContext context = new BookShopContext();
        DbInitializer.ResetDatabase(context);

        string result = GetBooksByAgeRestriction(context, Console.ReadLine());
        Console.WriteLine(result);
    }

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
}