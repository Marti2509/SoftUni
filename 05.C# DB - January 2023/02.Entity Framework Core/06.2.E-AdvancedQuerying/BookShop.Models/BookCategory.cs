namespace BookShop.Models;

using System.ComponentModel.DataAnnotations.Schema;

public class BookCategory
{
    [ForeignKey(nameof(Book))]
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;

    [ForeignKey(nameof(Category))]
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}