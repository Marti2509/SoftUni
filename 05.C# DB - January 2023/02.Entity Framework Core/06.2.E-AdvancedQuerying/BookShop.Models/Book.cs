namespace BookShop.Models;

using BookShop.Models.Enums;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Book
{
    public Book()
    {
        BookCategories = new HashSet<BookCategory>();
    }

    [Key]
    public int BookId { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    [MaxLength(50)]
    public string Title { get; set; } = null!;

    [Column(TypeName = "nvarchar(1000)")]
    [MaxLength(1000)]
    public string Description { get; set; } = null!;

    public DateTime? ReleaseDate { get; set; }

    public int Copies { get; set; }

    public decimal Price { get; set; }

    public EditionType EditionType { get; set; }

    public AgeRestriction AgeRestriction { get; set; }

    [ForeignKey(nameof(Author))]
    public int AuthorId { get; set; }
    public virtual Author Author { get; set; } = null!;

    public virtual ICollection<BookCategory> BookCategories { get; set; }
}