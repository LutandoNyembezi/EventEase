namespace EventEase.Models
{
    public class Event
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public DateTime Date { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
        public int VenueId { get; set; }

        public Venue? Venue { get; set; }
    }
}
