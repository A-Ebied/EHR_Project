using EHR_API.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace EHR_API.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Governorate> Governorates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Governorate>().ToTable("Governorate");
        }
    }
}
