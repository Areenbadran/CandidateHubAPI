using Microsoft.EntityFrameworkCore;

namespace CndidateHubAPI.Model
{
    public class AppDbContext : DbContext
    {
        public DbSet<Candidate> Candidates { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Candidate>()
                .HasIndex(c => c.Email)
                .IsUnique();
        }
    }
}
