using Microsoft.EntityFrameworkCore;
using VideoRental.Entities;

namespace VideoRental.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Video> Videos { get; set; }
        public DbSet<VideoType> VideoTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Seed();
        }
    }
}
