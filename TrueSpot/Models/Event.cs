namespace TrueSpot.Models
{
    public class Event
    {
        public Guid Id { get; set; }

        public Guid CreatorUserId { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;

        public DateTime StartDate { get; set; } = default!;
        public DateTime? EndDate { get; set; }
    }
}
