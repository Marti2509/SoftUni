using static Homies.Data.DataConstants.Event;
using System.ComponentModel.DataAnnotations;

namespace Homies.Models
{
    public class AddEditViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(NameMax, MinimumLength = NameMin)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(DescMax, MinimumLength = DescMin)]
        public string Description { get; set; } = null!;

        [Required]
        public string Start { get; set; } = null!;

        [Required]
        public string End { get; set; } = null!;

        [Required]
        public int TypeId { get; set; }

        public List<TypeViewModel> Types { get; set; } = new List<TypeViewModel>();

        public string? CreatorId { get; set; }
    }
}
