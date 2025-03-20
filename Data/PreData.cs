using System;
using System.Collections.Generic;
using System.Linq;
using AssuranceSNTL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AssuranceSNTL.Data;

public static class PreData
{
    public static void SeedData(this IServiceProvider serviceCollection)
    {
        using (var context = new AppDbContext(serviceCollection.GetRequiredService<DbContextOptions<AppDbContext>>()))
        {
            if (context is null)
                throw new ArgumentNullException("Context is null ");

            SeedClients(context);
            SeedVoitures(context);
            context.SaveChanges();
        }
    }

    private static void SeedClients(AppDbContext context)
    {
        if(context.Clients.Any())
            return;
        
        var clients = new List<Client>
        {
            new Client
            {
                Nom = "Doe",
                Prenom = "John",
                CIN = "AB123456",
                Addresse = "123 Main St, Springfield",
                Telephone = "555-1234",
                DateNaissance = new DateTime(1985, 5, 15)
            },
            new Client
            {
                Nom = "Smith",
                Prenom = "Jane",
                CIN = "CD654321",
                Addresse = "456 Elm St, Shelbyville",
                Telephone = "555-5678",
                DateNaissance = new DateTime(1990, 8, 22)
            },
            new Client
            {
                Nom = "Johnson",
                Prenom = "Robert",
                CIN = "EF987654",
                Addresse = "789 Oak St, Capital City",
                Telephone = "555-8765",
                DateNaissance = new DateTime(1978, 3, 10)
            },
            new Client
            {
                Nom = "Williams",
                Prenom = "Mary",
                CIN = "GH456789",
                Addresse = "321 Pine St, Ogdenville",
                Telephone = "555-4321",
                DateNaissance = new DateTime(1982, 11, 30)
            },
            new Client
            {
                Nom = "Brown",
                Prenom = "Michael",
                CIN = "IJ654987",
                Addresse = "654 Maple St, North Haverbrook",
                Telephone = "555-6789",
                DateNaissance = new DateTime(1995, 7, 5)
            },
            new Client
            {
                Nom = "Jones",
                Prenom = "Patricia",
                CIN = "KL321654",
                Addresse = "987 Cedar St, Brockway",
                Telephone = "555-3456",
                DateNaissance = new DateTime(1988, 9, 18)
            },
            new Client
            {
                Nom = "Garcia",
                Prenom = "Linda",
                CIN = "MN789123",
                Addresse = "147 Birch St, Cypress Creek",
                Telephone = "555-7890",
                DateNaissance = new DateTime(1975, 12, 25)
            },
            new Client
            {
                Nom = "Miller",
                Prenom = "William",
                CIN = "OP456321",
                Addresse = "258 Walnut St, Shelbyville",
                Telephone = "555-2345",
                DateNaissance = new DateTime(1992, 4, 14)
            },
            new Client
            {
                Nom = "Davis",
                Prenom = "Elizabeth",
                CIN = "QR123789",
                Addresse = "369 Spruce St, Capital City",
                Telephone = "555-6781",
                DateNaissance = new DateTime(1980, 6, 20)
            },
            new Client
            {
                Nom = "Rodriguez",
                Prenom = "David",
                CIN = "ST987456",
                Addresse = "741 Cherry St, Ogdenville",
                Telephone = "555-8123",
                DateNaissance = new DateTime(1970, 2, 12)
            }
        };

        context.Clients.AddRange(clients);
    }
    private static void SeedVoitures(AppDbContext context)
    {
        if(context.Voitures.Any())
            return;
        
    }
}