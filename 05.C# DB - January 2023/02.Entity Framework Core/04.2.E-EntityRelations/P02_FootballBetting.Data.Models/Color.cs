namespace P02_FootballBetting.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Color
{
    public Color()
    {
        PrimaryKitTeams = new HashSet<Team>();
        SecondaryKitTeams = new HashSet<Team>();
    }

    [Key]
    public int ColorId { get; set; }

    [Required]
    [MaxLength(10)]
    public string Name { get; set; } = null!;

    public virtual ICollection<Team> PrimaryKitTeams { get; set; }

    public virtual ICollection<Team> SecondaryKitTeams { get; set; }
}
