using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AssuranceSNTL.Data;
using AssuranceSNTL.Models;
using AssuranceSNTL.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace AssuranceSNTL.Repository.Implemenation;

public class ClientRepository : IClientRepository
{
    private readonly AppDbContext _context;

    public ClientRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Client> CreateClientAsync(Client client)
    {
        await _context.Clients.AddAsync(client);
        await _context.SaveChangesAsync();
        return client;
    }

    public  async Task<IEnumerable<Client>?> GetAllClientsAsync()
    {
        return await _context.Clients.ToListAsync();
    }

    public async Task<Client?> GetClientByIdAsync(int id)
    {
        return await _context.Clients.FindAsync(id);
    }

    public async Task<Client?> GetClientByCinAsync(string cin)
    {
        return await _context.Clients.FirstOrDefaultAsync(c => c.CIN.ToUpper().Equals(cin.ToUpper()));
    }

    public async Task<Client> UpdateClientAsync(int id, Client client)
    {
        var  get_client = await GetClientByIdAsync(id);
        get_client.CIN = client.CIN;
        get_client.Addresse = client.Addresse;
        get_client.Voitures = client.Voitures;
        get_client.Nom = client.Nom;
        get_client.Prenom = client.Prenom;
        get_client.Telephone = client.Telephone;
        get_client.DateNaissance = client.DateNaissance;
        get_client.DateUpdated = DateTimeOffset.Now;
        _context.Entry(get_client).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return client;
    }

    public async Task<bool> DeleteClientByIdAsync(int id)
    {
        var client = await GetClientByIdAsync(id);
        if (client is null)
            return false;
        _context.Clients.Remove(client);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteClientByCinAsync(string cin)
    {
        var client = await GetClientByCinAsync(cin);
        if (client is null)
            return false;
        _context.Clients.Remove(client);
        await _context.SaveChangesAsync();
        return true;
    }
}