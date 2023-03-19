namespace BookShop;

using BookShop.Data;
using BookShop.Initialializer;

public class StartUp
{
    static void Main(string[] args)
    {
        using BookShopContext context = new BookShopContext();
        DbInitializer.ResetDatabase(context);
    }
}