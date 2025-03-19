using System;
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
        
        context.Clients.AddRange(
            new Client
            {
                
            });
    }
    private static void SeedVoitures(AppDbContext context)
    {
        if(context.Voitures.Any())
            return;
        
    }

    
}