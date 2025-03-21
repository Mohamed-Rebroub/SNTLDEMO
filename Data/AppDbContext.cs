﻿using System.Reflection.Metadata.Ecma335;
using AssuranceSNTL.Models;
using Microsoft.EntityFrameworkCore;

namespace AssuranceSNTL.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Voiture> Voitures { get; set; }
        public DbSet<PackAssurance> PackAssurances {  get; set; }
        public DbSet<TypeAssurance> TypeAssurances { get; set; }
        public DbSet<Contrat> contrats { get; set; }
        public DbSet<ContratTypeAssurance> ContratTypeAssurance { get; set; }
        public DbSet<PackTypeAssurance> PackTypeAssurances { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Voiture>()
                .HasOne(v => v.Client)
                .WithMany(v => v.Voitures)
                .HasForeignKey(v => v.ClientId);


            modelBuilder.Entity<Contrat>()
                .HasOne(c => c.PackAssurance)
                .WithMany(p => p.Contrats)
                .HasForeignKey(c => c.PackAssuranceId);

           

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

            modelBuilder.Entity<PackTypeAssurance>()
                .HasKey(pta => new { pta.PackAssuranceID, pta.TypeAssuranceID });

            modelBuilder.Entity<PackTypeAssurance>()
                .HasOne(pta => pta.PackAssurance)
                .WithMany(pa => pa.PackTypeAssurances)
                .HasForeignKey(pta => pta.PackAssuranceID);

            modelBuilder.Entity<PackTypeAssurance>()
                .HasOne(pta => pta.TypeAssurance)
                .WithMany() 
                .HasForeignKey(pta => pta.TypeAssuranceID);

        }
    }
}
