namespace EventEase.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Location { get; set; }
        public int Capacity { get; set; }
        public required string ImageUrl { get; set; }
    }
}
