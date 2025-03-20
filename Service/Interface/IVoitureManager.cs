using System.Collections.Generic;
using System.Threading.Tasks;
using AssuranceSNTL.Models;
using AssuranceSNTL.Service.Response;

namespace AssuranceSNTL.Service.Interface;

public interface IVoitureManager
{
    Task<VoitureResponse> CreateVoitureAsync( Voiture voiture);
    Task<IEnumerable<Voiture>?> GetAllVoituresAsync();
    Task<VoitureResponse> GetVoitureByIdAsync(int id);
    Task<VoitureResponse> GetVoitureByImmatriculationAsync(string immatriculation);
    Task<VoitureResponse> UpdateVoitureAsync(int id, Voiture voiture);
    Task<bool> DeleteVoitureByIdAsync(int id);
    Task<bool> DeleteVoitureByImmatriculationAsync(string immatriculation);
}