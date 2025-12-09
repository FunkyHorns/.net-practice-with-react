namespace Practice.Domain
{
    public class Activity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string? Title { get; set; } 
        public DateTime Date { get; set; }
        public required string Desciription { get; set; }
        public required string Category { get; set; }
        public required string IsCancelled { get; set; }

        // Location details
        public required string City { get; set; }   
        public required string Venue { get; set; }
        public double Latitude { get; set; }
    }
}
