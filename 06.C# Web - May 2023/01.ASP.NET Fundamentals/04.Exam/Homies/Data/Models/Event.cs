using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static Homies.Data.DataConstants.Event;

namespace Homies.Data.Models
{
    [Comment("Table for the events")]
    public class Event
    {
        [Comment("The id of the event")]
        [Required]
        [Key]
        public int Id { get; set; }

        [Comment("The name of the event")]
        [Required]
        [StringLength(NameMax, MinimumLength = NameMin)]
        public string Name { get; set; } = null!;

        [Comment("The description of the event")]
        [Required]
        [StringLength(DescMax, MinimumLength = DescMin)]
        public string Description { get; set; } = null!;

        [Comment("The organizers' id")]
        [Required]
        public string OrganiserId { get; set; } = null!;

        [Comment("The organizer")]
        [ForeignKey(nameof(OrganiserId))]
        public IdentityUser Organiser { get; set; } = null!;

        [Comment("The creation date and time of the event")]
        [Required]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd H:mm")]
        public DateTime CreatedOn { get; set; }

        [Comment("The start date and time of the event")]
        [Required]
        public DateTime Start { get; set; }

        [Comment("The end date and time of the event")]
        [Required]
        public DateTime End { get; set; }

        [Comment("The types' id")]
        [Required]
        public int TypeId { get; set; }

        [Comment("The type")]
        [ForeignKey(nameof(TypeId))]
        public Type Type { get; set; } = null!;

        [Comment("The list with the participants")]
        public ICollection<EventParticipant> EventsParticipants { get; set; } = new List<EventParticipant>();
    }
}
