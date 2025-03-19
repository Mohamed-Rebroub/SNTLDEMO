using System.Collections.Generic;
using System.Threading.Tasks;
using AssuranceSNTL.Models;
using AssuranceSNTL.Repository.Interface;

namespace AssuranceSNTL.Repository.Implemenation;

public class ClientRepository : IClientRepository
{
    public Task<Client> CreateClientAsync(Client client)
    {
        throw new System.NotImplementedException();
    }

    public Task<IEnumerable<Client>?> GetAllClientsAsync()
    {
        throw new System.NotImplementedException();
    }

    public Task<Client?> GetClientByIdAsync(int id)
    {
        throw new System.NotImplementedException();
    }

    public Task<Client?> GetClientByCin(string cin)
    {
        throw new System.NotImplementedException();
    }

    public Task<Client> UpdateClientAsync(int id, Client client)
    {
        throw new System.NotImplementedException();
    }

    public Task<bool> DeleteClientByIdAsync(int id)
    {
        throw new System.NotImplementedException();
    }

    public Task<bool> DeleteClientByCinAsync(string cin)
    {
        throw new System.NotImplementedException();
    }
}