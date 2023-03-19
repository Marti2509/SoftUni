namespace BookShop.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Author
{
    public Author()
    {
        Books = new HashSet<Book>();
    }

    [Key]
    public int AuthorId { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    [MaxLength(50)]
    public string? FirstName { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    [MaxLength(50)]
    public string LastName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; }
}