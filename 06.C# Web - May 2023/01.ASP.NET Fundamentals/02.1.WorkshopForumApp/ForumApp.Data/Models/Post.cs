using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using static ForumApp.Data.Models.DataConstants.Post;

namespace ForumApp.Data.Models
{
    [Comment("Posts table")]
    public class Post
    {
        [Comment("Post id")]
        [Key]
        public int Id { get; init; }

        [Comment("Post Title")]
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = null!;

        [Comment("Post Content")]
        [Required]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength)]
        public string Content { get; set; } = null!;
    }
}
