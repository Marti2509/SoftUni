﻿namespace P02_FootballBetting.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Town
{
    public Town()
    {
        Teams = new HashSet<Team>();
    }

    [Key]
    public int TownId { get; set; }

    [Required]
    [MaxLength(40)]
    public string Name { get; set; } = null!;

    [ForeignKey(nameof(Country))]
    public int CountryId { get; set; }
    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Team> Teams { get; set; }
}