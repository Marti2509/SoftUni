using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using static Homies.Data.DataConstants.Type;

namespace Homies.Data.Models
{
    [Comment("The table for the types")]
    public class Type
    {
        [Comment("The id of the type")]
        [Required]
        [Key]
        public int Id { get; set; }

        [Comment("The name of the type")]
        [Required]
        [StringLength(NameMax, MinimumLength = NameMin)]
        public string Name { get; set; } = null!;

        [Comment("A list with the events with this type")]
        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
