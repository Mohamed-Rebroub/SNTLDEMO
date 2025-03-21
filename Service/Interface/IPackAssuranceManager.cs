using AssuranceSNTL.Models;
using AssuranceSNTL.Service.Response;

namespace AssuranceSNTL.Service.Interface
{
    public interface IPackAssuranceManager
    {
        Task<PackAssuranceResponse> CreatePackAssuranceAsync(PackAssurance packAssurance, List<int> AssuranceIds);
        Task<IEnumerable<PackAssurance>?> GetAllPacksAssuranceAsync();
        Task<PackAssuranceResponse> GetPackAssuranceByIdAsync(int id);
        Task<PackAssuranceResponse> GetPackAssuranceByNameAsync(string name);
        Task<PackAssuranceResponse> UpdatePackAssuranceAsync(int id, PackAssurance packAssurance, List<int> AssuranceIds);
        Task<PackAssuranceResponse> DeletePackAssuranceAsync(int id);
    }
}
