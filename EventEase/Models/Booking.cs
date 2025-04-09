namespace EventEase.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public required string CustomerName { get; set; }
        public DateTime BookingDate { get; set; }
        public int EventId { get; set; }

        public Event? Event { get; set; }
    }
}
