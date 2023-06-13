using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static Library.Data.DataConstants.Book;

namespace Library.Data.Models
{
    [Comment("Table for the books")]
    public class Book
    {
        [Comment("Book's primary key")]
        [Required]
        public int Id { get; init; }

        [Comment("Book's title")]
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = null!;

        [Comment("Book's author")]
        [Required]
        [StringLength(AuthorMaxLength, MinimumLength = AuthorMinLength)]
        public string Author { get; set; } = null!;

        [Comment("Book's description")]
        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)] 
        public string Description { get; set; } = null!;

        [Comment("Book's image URL")]
        [Required]
        public string ImageUrl { get; set; } = null!;

        [Comment("Book's rating")]
        [Required]
        public decimal Rating { get; set; }

        [Comment("Book's category Id")]
        [Required]
        public int CategoryId { get; set; }

        [Required]
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        public List<IdentityUserBook> UserBooks { get; set; } = new List<IdentityUserBook>();
    }
}
