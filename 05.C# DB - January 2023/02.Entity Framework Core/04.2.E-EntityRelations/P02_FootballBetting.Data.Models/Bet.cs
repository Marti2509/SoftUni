﻿namespace P02_FootballBetting.Data.Models;

using P02_FootballBetting.Data.Models.Enum;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Bet
{
    [Key]
    public int BetId { get; set; }

    [Required]
    public decimal Amount { get; set; }

    [Required]
    public BetPrediction Prediction { get; set; }

    [Required]
    public DateTime DateTime { get; set; }

    [ForeignKey(nameof(User))]
    public int UserId { get; set; }
    public virtual User User { get; set; } = null!;

    [ForeignKey(nameof(Game))]
    public int GameId { get; set; }
    public virtual Game Game { get; set; } = null!;
}