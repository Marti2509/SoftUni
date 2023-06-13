using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Models
{
    [Comment("User Books")]
    public class IdentityUserBook
    {
        [Comment("Collector Id")]
        [Required]
        public string CollectorId { get; set; } = null!;

        [Comment("Collector")]
        [Required]
        [ForeignKey(nameof(CollectorId))]
        public IdentityUser Collector { get; set; } = null!;

        [Comment("Book Id")]
        [Required]
        public int BookId { get; set; }

        [Comment("Book")]
        [Required]
        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; } = null!;
    }
}