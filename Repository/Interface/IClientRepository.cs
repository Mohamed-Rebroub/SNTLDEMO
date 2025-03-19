using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AssuranceSNTL.Models;

namespace AssuranceSNTL.Repository.Interface;

public interface IClientRepository
{
    Task<Client> CreateClientAsync(Client client);
    Task<IEnumerable<Client>?> GetAllClientsAsync();
    Task<Client?> GetClientByIdAsync(int id);
    Task<Client?> GetClientByCin(string cin);
    Task<Client> UpdateClientAsync(int id, Client client);
    Task<bool> DeleteClientByIdAsync(int id);
    Task<bool> DeleteClientByCinAsync(string cin);
}