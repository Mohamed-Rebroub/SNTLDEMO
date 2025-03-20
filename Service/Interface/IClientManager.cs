using System.Collections.Generic;
using System.Threading.Tasks;
using AssuranceSNTL.Models;
using AssuranceSNTL.Service.Response;

namespace AssuranceSNTL.Service.Interface;

public interface IClientManager
{
    Task<ClientResponse> CreateClientAsync(Client client);
    Task<IEnumerable<Client>?> GetAllClientsAsync();
    Task<ClientResponse> GetClientByIdAsync(int id);
    Task<ClientResponse> GetClientByCinAsync(string cin);
    Task<ClientResponse> UpdateClientAsync(int id, Client client);
    Task<ClientResponse> DeleteClientByIdAsync(int id);
    Task<ClientResponse> DeleteClientByCinAsync(string cin);
}