namespace P02_FootballBetting.Data.Models;

using System.ComponentModel.DataAnnotations;

public class User
{
    public User()
    {
        Bets = new HashSet<Bet>();
    }

    [Key]
    public int UserId { get; set; }

    [Required]
    [MaxLength(30)]
    public string Username { get; set; } = null!;

    [Required]
    [MaxLength(127)]
    public string Password { get; set; } = null!;

    [Required]
    [MaxLength(320)]
    public string Email { get; set; } = null!;

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = null!;

    [Required]
    public decimal Balance { get; set; }

    public virtual ICollection<Bet> Bets { get; set; }
}