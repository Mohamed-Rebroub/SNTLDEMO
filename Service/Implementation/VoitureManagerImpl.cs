using System.Collections.Generic;
using System.Threading.Tasks;
using AssuranceSNTL.Models;
using AssuranceSNTL.Repository.Interface;
using AssuranceSNTL.Service.Interface;
using AssuranceSNTL.Service.Response;

namespace AssuranceSNTL.Service.Implementation;

public class VoitureManagerImpl : IVoitureManager
{
    private readonly IVoitureRepository _voitureRepository;
    private readonly IClientRepository _clientRepository;
    public VoitureManagerImpl(IVoitureRepository voitureRepository, IClientRepository clientRepository)
    {
        _voitureRepository = voitureRepository;
        _clientRepository = clientRepository;
    }

    public async Task<VoitureResponse> CreateVoitureAsync(Voiture voiture)
    {
        var GetVoiture = await _voitureRepository.GetVoitureByIdAsync(voiture.VoitureId);
    }

    public Task<IEnumerable<Voiture>?> GetAllVoituresAsync()
    {
        throw new System.NotImplementedException();
    }

    public Task<VoitureResponse> GetVoitureByIdAsync(int id)
    {
        throw new System.NotImplementedException();
    }

    public Task<VoitureResponse> GetVoitureByImmatriculationAsync(string immatriculation)
    {
        throw new System.NotImplementedException();
    }

    public Task<VoitureResponse> UpdateVoitureAsync(int id, Voiture voiture)
    {
        throw new System.NotImplementedException();
    }

    public Task<bool> DeleteVoitureByIdAsync(int id)
    {
        throw new System.NotImplementedException();
    }

    public Task<bool> DeleteVoitureByImmatriculationAsync(string immatriculation)
    {
        throw new System.NotImplementedException();
    }
}