namespace Homies.Models
{
    public class EventViewModel
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Start { get; set; }

        public string End { get; set; }
        
        public int TypeId { get; set; }
    }
}
