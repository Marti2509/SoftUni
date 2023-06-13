using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using static Library.Data.DataConstants.Category;

namespace Library.Data.Models
{
    [Comment("Table for the categories")]
    public class Category
    {
        [Comment("Category's primary key")]
        [Required]
        public int Id { get; init; }

        [Comment("Category's name")]
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        public List<Book> Books { get; set; } = new List<Book>();
    }
}