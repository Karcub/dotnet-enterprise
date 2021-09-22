using Microsoft.EntityFrameworkCore;

namespace dotnet_enterprise.Models
{
    public class EventContext : DbContext
    {
        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        {
        }

        public DbSet<EventItem> EventItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventItem>().HasData(new EventInitializer().EventItems);
        }
    }
}