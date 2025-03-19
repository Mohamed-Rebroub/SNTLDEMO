using System.Reflection.Metadata.Ecma335;
using AssuranceSNTL.Models;
using Microsoft.EntityFrameworkCore;

namespace AssuranceSNTL.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Voiture> Voitures { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Voiture>()
                .HasOne(v => v.Client)
                .WithMany(v => v.Voitures)
                .HasForeignKey(v => v.ClientId);
        }
    }
}
