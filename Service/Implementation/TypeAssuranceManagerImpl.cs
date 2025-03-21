using AssuranceSNTL.Models;
using AssuranceSNTL.Repository.Interface;
using AssuranceSNTL.Service.Interface;
using AssuranceSNTL.Service.Response;

namespace AssuranceSNTL.Service.Implementation
{
    public class TypeAssuranceManagerImpl : ITypeAssuranceManager
    {
        private readonly ITypeAssuranceRepo _typeAssuranceRepo;

        public TypeAssuranceManagerImpl(ITypeAssuranceRepo typeAssuranceRepo)
        {
            _typeAssuranceRepo = typeAssuranceRepo;
        }

        public async Task<TypeAssuranceResponse> CreateTypeAssuranceAsync(TypeAssurance typeAssurance)
        {
            var existingTypeAssurance = await _typeAssuranceRepo.GetAllAssurancesByName(typeAssurance.Nom);
            if (existingTypeAssurance != null && existingTypeAssurance.Any())
                return new TypeAssuranceResponse { Message = "TypeAssurance existe déjà." };

            await _typeAssuranceRepo.AddTypeAssuranceAsync(typeAssurance);
            return new TypeAssuranceResponse { TypeAssurance = typeAssurance };
        }

        public async Task<IEnumerable<TypeAssurance>?> GetAllTypeAssurancesAsync()
        {
            return await _typeAssuranceRepo.GetAllAssurancesAsync();
        }

        public async Task<TypeAssuranceResponse> GetTypeAssuranceByIdAsync(int id)
        {
            var typeAssurance = await _typeAssuranceRepo.GetAllAssurancesById(id);
            if (typeAssurance == null || !typeAssurance.Any())
                return new TypeAssuranceResponse { Message = "TypeAssurance non trouvé." };
            return new TypeAssuranceResponse { TypeAssurance = typeAssurance.First() };
        }

        public async Task<IEnumerable<TypeAssurance>?> GetTypeAssurancesByNameAsync(string name)
        {
            return await _typeAssuranceRepo.GetAllAssurancesByName(name);
        }

        public async Task<IEnumerable<TypeAssurance>?> GetTypeAssurancesByPriceAsync(decimal price)
        {
            return await _typeAssuranceRepo.GetAllAssurancesByPrice(price);
        }

        public async Task<TypeAssuranceResponse> UpdateTypeAssuranceAsync(int id, TypeAssurance typeAssurance)
        {
            var existingTypeAssurance = await _typeAssuranceRepo.GetAllAssurancesById(id);
            if (existingTypeAssurance == null || !existingTypeAssurance.Any())
                return new TypeAssuranceResponse { Message = "TypeAssurance non trouvé." };

            await _typeAssuranceRepo.UpdateTypeAssuranceAsync(typeAssurance);
            return new TypeAssuranceResponse { TypeAssurance = typeAssurance };
        }

        public async Task<TypeAssuranceResponse> DeleteTypeAssuranceAsync(int id)
        {
            var result = await _typeAssuranceRepo.DeleteTypeAssuranceAsync(id);
            if (!result)
                return new TypeAssuranceResponse { Message = "TypeAssurance non trouvé." };
            return new TypeAssuranceResponse { Message = "TypeAssurance supprimé avec succès." };
        }
    }
}