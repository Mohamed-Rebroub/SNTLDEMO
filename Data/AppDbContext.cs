using System.Reflection.Metadata.Ecma335;
using AssuranceSNTL.Models;
using Microsoft.EntityFrameworkCore;

namespace AssuranceSNTL.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Voiture> Voitures { get; set; }
        public DbSet<PackAssurance> packAssurances {  get; set; }
        public DbSet<TypeAssurance> typeAssurances { get; set; }
        public DbSet<Contrat> contrats { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Voiture>()
                .HasOne(v => v.Client)
                .WithMany(v => v.Voitures)
                .HasForeignKey(v => v.ClientId);


            // Relation entre Contrat et PackAssurance (Many-to-One)
            modelBuilder.Entity<Contrat>()
                .HasOne(c => c.PackAssurance)
                .WithMany(p => p.Contrats)
                .HasForeignKey(c => c.PackAssuranceId);

           

            // Relation Many-to-Many entre Contrat et TypeAssurance via la table de jointure ContratTypeAssurance
            modelBuilder.Entity<ContratTypeAssurance>()
                .HasKey(cta => new { cta.ContratId, cta.TypeAssuranceId });

            modelBuilder.Entity<ContratTypeAssurance>()
                .HasOne(cta => cta.Contrat)
                .WithMany(c => c.ContratTypeAssurances)
                .HasForeignKey(cta => cta.ContratId);

            modelBuilder.Entity<ContratTypeAssurance>()
                .HasOne(cta => cta.TypeAssurance)
                .WithMany(ta => ta.ContratTypeAssurances)
                .HasForeignKey(cta => cta.TypeAssuranceId);

            // Relation many-to-many entre PackAssurance et TypeAssurance via PackTypeAssurance
            modelBuilder.Entity<PackTypeAssurance>()
                .HasKey(pta => new { pta.PackAssuranceID, pta.TypeAssuranceID });

            modelBuilder.Entity<PackTypeAssurance>()
                .HasOne(pta => pta.PackAssurance)
                .WithMany(pa => pa.PackTypeAssurances)
                .HasForeignKey(pta => pta.PackAssuranceID);

            modelBuilder.Entity<PackTypeAssurance>()
                .HasOne(pta => pta.TypeAssurance)
                .WithMany() // Pas de navigation inverse depuis TypeAssurance
                .HasForeignKey(pta => pta.TypeAssuranceID);

        }
    }
}
