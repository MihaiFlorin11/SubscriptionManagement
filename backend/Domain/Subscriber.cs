namespace Domain
{
    public class Subscriber
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public Guid? SubscriptionId {  get; set; }

        public Subscription? Subscription { get; set; }

        public DateTime? SubscriptionStartedAtUtc { get; set; }

        public DateTime? SubscriptionExpiresAtUtc { get; set; }

        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }
}
