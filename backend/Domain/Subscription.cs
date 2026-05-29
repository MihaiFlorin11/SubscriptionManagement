namespace Domain
{
    public class Subscription
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int DurationInMonths { get; set; }

        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;

        public ICollection<Subscriber> Subscribers { get; set; } = new List<Subscriber>();
    }
}
