namespace P02_FootballBetting.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Game
{
    public Game()
    {
        PlayersStatistics = new HashSet<PlayerStatistic>();
        Bets = new HashSet<Bet>();
    }

    [Key]
    public int GameId { get; set; }

    [Required]
    public byte HomeTeamGoals { get; set; }

    [Required]
    public byte AwayTeamGoals { get; set; }

    [Required]
    public DateTime DateTime { get; set; }

    [Required]
    public double HomeTeamBetRate { get; set; }

    [Required]
    public double AwayTeamBetRate { get; set; }

    [Required]
    public double DrawBetRate { get; set; }

    [Required]
    [MaxLength(7)]
    public string Result { get; set; } = null!;

    [ForeignKey(nameof(HomeTeam))]
    public int HomeTeamId { get; set; }
    public virtual Team HomeTeam { get; set; } = null!;

    [ForeignKey(nameof(AwayTeam))]
    public int AwayTeamId { get; set; }
    public virtual Team AwayTeam { get; set; } = null!;

    public virtual ICollection<PlayerStatistic> PlayersStatistics { get; set; }

    public virtual ICollection<Bet> Bets { get; set; }
}