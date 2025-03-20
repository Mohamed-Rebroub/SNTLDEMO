using System.Collections.Generic;
using System.Threading.Tasks;
using AssuranceSNTL.Models;

namespace AssuranceSNTL.Repository.Interface;

public interface IVoitureRepository
{
    Task<Voiture> CreateVoitureAsync( Voiture voiture);
    Task<IEnumerable<Voiture>?> GetAllVoituresAsync();
    Task<Voiture?> GetVoitureByIdAsync(int id);
    Task<Voiture?> GetVoitureByImmatriculationAsync(string immatriculation);
    Task<Voiture?> UpdateVoitureAsync(int id, Voiture voiture);
    Task<bool> DeleteVoitureByIdAsync(int id);
    Task<bool> DeleteVoitureByImmatriculationAsync(string immatriculation);
}