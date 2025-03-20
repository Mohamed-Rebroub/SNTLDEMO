using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AssuranceSNTL.Data;
using AssuranceSNTL.Models;
using AssuranceSNTL.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace AssuranceSNTL.Repository.Implemenation;

public class VoitureRepository : IVoitureRepository
{
    private AppDbContext _context;

    public VoitureRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Voiture> CreateVoitureAsync(Voiture voiture)
    {
        await _context.Voitures.AddAsync(voiture);
        await _context.SaveChangesAsync();
        return voiture;
    }

    public async Task<IEnumerable<Voiture>?> GetAllVoituresAsync()
    {
        return await _context.Voitures
            .Include(v=>v.Client)
            .ToListAsync();
    }

    public  async Task<Voiture?> GetVoitureByIdAsync(int id)
    {
        return await _context.Voitures.Include(v => v.Client)
            .FirstOrDefaultAsync(c => c.ClientId.Equals(id));
    }

    public async Task<Voiture?> GetVoitureByImmatriculationAsync(string immatriculation)
    {
        return await _context.Voitures.FirstOrDefaultAsync(v =>
            v.Immatriculation.ToUpper().Equals(immatriculation.ToUpper()));
    }

    public async Task<Voiture?> UpdateVoitureAsync(int id, Voiture voiture)
    {
        var getVoiture = await GetVoitureByIdAsync(id);
        if (getVoiture is null)
            return null;
        getVoiture.ClientId = voiture.ClientId;
        getVoiture.Immatriculation = voiture.Immatriculation;
        getVoiture.DateUpdated = DateTimeOffset.Now;
        getVoiture.Annee = voiture.Annee;
        getVoiture.Marque = voiture.Marque;
        getVoiture.PuissanceFiscale = voiture.PuissanceFiscale;
        getVoiture.Model = voiture.Model;
        _context.Entry(getVoiture).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return voiture;
    }
    

    public async Task<bool> DeleteVoitureByIdAsync(int id)
    {
        var voiture = await GetVoitureByIdAsync(id);
        if (voiture is null)
            return false;
        _context.Voitures.Remove(voiture);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteVoitureByImmatriculationAsync(string immatriculation)
    {
        var voiture = await GetVoitureByImmatriculationAsync(immatriculation);
        if (voiture is null)
            return false;
        _context.Voitures.Remove(voiture);
        await _context.SaveChangesAsync();
        return true;
    }

}