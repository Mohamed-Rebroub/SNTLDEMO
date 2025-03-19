using AssuranceSNTL.Models;
using AssuranceSNTL.Repository.Interface;

namespace AssuranceSNTL.Repository
{
    public class TypeAssuranceRepo : ITypeAssuranceRepo
    {
        public Task AddTypeAssuranceAsync(TypeAssurance typeAssurance)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTypeAssuranceAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TypeAssurance>> GetAllAssurancesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TypeAssurance>> GetAllAssurancesById()
        {
            throw new NotImplementedException();
        }

        public Task UpdateTypeAssuranceAsync(TypeAssurance typeAssurance)
        {
            throw new NotImplementedException();
        }
    }
}
