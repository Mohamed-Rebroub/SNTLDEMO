using System.Collections.Generic;
using System.Threading.Tasks;
using AssuranceSNTL.Models;

namespace AssuranceSNTL.Repository.Interface
{
    public interface IPackAssuranceRepo
    {
        Task<IEnumerable<PackAssurance>> GetAllPacksAssuranceAsync();
        Task<PackAssurance> GetPackAssuranceByIdAsync(int id);
        Task<PackAssurance> GetPackAssuranceByIdName(int id);


        Task AddPackAssuranceAsync(PackAssurance packAssurance, List<int> AssuranceIds);
        Task UpdatePackAssuranceAsync(PackAssurance packAssurance, List<int> AssuranceIds);
        Task DeletePackAssuranceAsync(int id);
    }
}
