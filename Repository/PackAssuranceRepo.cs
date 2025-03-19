using AssuranceSNTL.Models;
using AssuranceSNTL.Repository.Interface;

namespace AssuranceSNTL.Repository
{
    public class PackAssuranceRepo : IPackAssuranceRepo
    {
        public Task AddPackAssuranceAsync(PackAssurance packAssurance, List<int> AssuranceIds)
        {
            throw new NotImplementedException();
        }

        public Task DeletePackAssuranceAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PackAssurance>> GetAllPacksAssuranceAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PackAssurance> GetPackAssuranceByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePackAssuranceAsync(PackAssurance packAssurance, List<int> AssuranceIds)
        {
            throw new NotImplementedException();
        }
    }
}
