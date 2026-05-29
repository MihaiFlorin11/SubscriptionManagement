using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class SubscriptionManagementDbContext : DbContext
    {
        public SubscriptionManagementDbContext(DbContextOptions<SubscriptionManagementDbContext> options) : base(options)
        {
                
        }

        public DbSet<Subscriber> Subscribers { get; set; }

        public DbSet<Subscription> Subscriptions { get; set; }
    }
}
