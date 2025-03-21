using AssuranceSNTL.Models;
using AssuranceSNTL.Service.Response;

namespace AssuranceSNTL.Service.Interface
{
    public interface ITypeAssuranceManager
    {
        Task<TypeAssuranceResponse> CreateTypeAssuranceAsync(TypeAssurance typeAssurance);
        Task<IEnumerable<TypeAssurance>?> GetAllTypeAssurancesAsync();
        Task<TypeAssuranceResponse> GetTypeAssuranceByIdAsync(int id);
        Task<IEnumerable<TypeAssurance>?> GetTypeAssurancesByNameAsync(string name);
        Task<IEnumerable<TypeAssurance>?> GetTypeAssurancesByPriceAsync(decimal price);
        Task<TypeAssuranceResponse> UpdateTypeAssuranceAsync(int id, TypeAssurance typeAssurance);
        Task<TypeAssuranceResponse> DeleteTypeAssuranceAsync(int id);
    }
}
