using System.Collections.Generic;
using System.Threading.Tasks;
using AssuranceSNTL.Models;
using AssuranceSNTL.Repository.Interface;
using AssuranceSNTL.Service.Interface;
using AssuranceSNTL.Service.Response;

namespace AssuranceSNTL.Service.Implementation;

public class ClientManagerIMpl : IClientManager
{
    private readonly IClientRepository _clientRepository;

    public ClientManagerIMpl(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public  async Task<ClientResponse> CreateClientAsync(Client client)
    {

        var getClient = await _clientRepository.GetClientByIdAsync(client.CLientId);
        if(getClient is not null)
            return new ClientResponse { Message = "Client Exist Deja" };
        var returnClient = await _clientRepository.CreateClientAsync(client);
        return new ClientResponse { Client = returnClient };
    }

    public async Task<IEnumerable<Client>?> GetAllClientsAsync()
    {
        return await _clientRepository.GetAllClientsAsync();
    }

    public async Task<ClientResponse> GetClientByIdAsync(int id)
    {
        var client = await _clientRepository.GetClientByIdAsync(id);
        if (client is null)
            return new ClientResponse { Message = "Client N'existe Pas" };
        return new ClientResponse { Client = client };
    }

    public async Task<ClientResponse> GetClientByCinAsync(string cin)
    {
        var client = await _clientRepository.GetClientByCinAsync(cin);
        if (client is null)
            return new ClientResponse { Message = "Client N'existe Pas" };
        return new ClientResponse { Client = client };
    }

    public async Task<ClientResponse> UpdateClientAsync(int id, Client client)
    {
        var getClient = await _clientRepository.GetClientByIdAsync(id);
        if (getClient is null)
            return new ClientResponse { Message = "Client N'Exist Pas" };
        return new ClientResponse { Client = getClient };
    }

    public async Task<ClientResponse> DeleteClientByIdAsync(int id)
    {
        var result = await _clientRepository.DeleteClientByIdAsync(id);
        if (!result)
            return new ClientResponse { Message = "CLient N'existe Pas" };
        return new ClientResponse { Message = "Client Ete Supprimer" };
    }

    public async Task<ClientResponse> DeleteClientByCinAsync(string cin)
    {
        var result = await _clientRepository.DeleteClientByCinAsync(cin);
        if (!result)
            return new ClientResponse { Message = "CLient N'existe Pas" };
        return new ClientResponse { Message = "Client Ete Supprimer" };
    }
}