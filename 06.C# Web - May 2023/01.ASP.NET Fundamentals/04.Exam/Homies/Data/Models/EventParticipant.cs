using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homies.Data.Models
{
    [Comment("Table for the event and its participants")]
    public class EventParticipant
    {
        [Comment("The id of the participant")]
        [Required]
        public string HelperId { get; set; } = null!;

        [Comment("The participant")]
        [ForeignKey(nameof(HelperId))]
        public IdentityUser Helper { get; set; } = null!;

        [Comment("The id of the event")]
        [Required]
        public int EventId { get; set; }

        [Comment("The event")]
        [ForeignKey(nameof(EventId))]
        public Event Event { get; set; } = null!;
    }
}