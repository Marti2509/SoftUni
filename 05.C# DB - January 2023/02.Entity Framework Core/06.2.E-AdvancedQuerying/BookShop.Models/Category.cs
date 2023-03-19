namespace BookShop.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Category
{
    public Category()
    {
        CategoryBooks = new HashSet<BookCategory>();
    }

    [Key]
    public int CategoryId { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    [MaxLength(50)]
    public string Name { get; set; } = null!;

    public virtual ICollection<BookCategory> CategoryBooks { get; set; }
}