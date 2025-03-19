using System.Collections.Generic;
using System.Threading.Tasks;
using AssuranceSNTL.Models;

namespace AssuranceSNTL.Repository.Interface
{
    public interface ITypeAssuranceRepo
    {
        Task<IEnumerable<TypeAssurance>> GetAllAssurancesAsync();
        Task<IEnumerable<TypeAssurance>> GetAllAssurancesById();

        Task AddTypeAssuranceAsync(TypeAssurance typeAssurance);
        Task UpdateTypeAssuranceAsync(TypeAssurance typeAssurance);
        Task DeleteTypeAssuranceAsync(int id);
    }
}
