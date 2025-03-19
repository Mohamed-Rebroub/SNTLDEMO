using System.Collections.Generic;
using System.Threading.Tasks;
using AssuranceSNTL.Models;

namespace AssuranceSNTL.Repository.Interface;

public interface IVoitureRepository
{
    Task<Voiture> CreateVoitureAsync( Voiture voiture);
    Task<IEnumerable<Voiture>?> GetAllVoituresAsync();
    Task<Voiture?> GetVoitureByIdAsync(int id);
    Task<Voiture?> GetVoitureByCinAsync(string immatriculation);
    Task<bool> DeleteVoitureById(int id);
    Task<bool> DeleteVoitureByImmatriculation(int immatriculation);
}