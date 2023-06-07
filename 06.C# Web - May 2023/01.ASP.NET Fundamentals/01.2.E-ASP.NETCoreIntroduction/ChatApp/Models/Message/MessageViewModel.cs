using System.ComponentModel.DataAnnotations;

namespace ChatApp.Models.Message
{
    public class MessageViewModel
    {
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Sender { get; set; } = null!;

        [Required]
        [StringLength(200)]
        public string Message { get; set; } = null!;
    }
}
