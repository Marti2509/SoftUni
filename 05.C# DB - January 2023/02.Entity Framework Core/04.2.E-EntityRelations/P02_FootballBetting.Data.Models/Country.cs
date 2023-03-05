namespace P02_FootballBetting.Data.Models;

using System.ComponentModel.DataAnnotations;

public class Country
{
    public Country()
    {
        Towns = new HashSet<Town>();
    }

    [Key]
    public int CountryId { get; set; }

    [Required]
    [MaxLength(60)]
    public string Name { get; set; } = null!;

    public virtual ICollection<Town> Towns { get; set; }
}