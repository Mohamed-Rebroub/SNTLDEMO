using AssuranceSNTL.Models;
using AssuranceSNTL.Repository.Interface;
using AssuranceSNTL.Service.Interface;
using AssuranceSNTL.Service.Response;

namespace AssuranceSNTL.Service.Implementation
{
    public class PackAssuranceManagerImpl : IPackAssuranceManager
    {
        private readonly IPackAssuranceRepo _packAssuranceRepo;

        public PackAssuranceManagerImpl(IPackAssuranceRepo packAssuranceRepo)
        {
            _packAssuranceRepo = packAssuranceRepo;
        }

        public async Task<PackAssuranceResponse> CreatePackAssuranceAsync(PackAssurance packAssurance, List<int> AssuranceIds)
        {
            var existingPack = await _packAssuranceRepo.GetPackAssuranceByIdName(packAssurance.Nom);
            if (existingPack != null)
                return new PackAssuranceResponse { Message = "PackAssurance existe déjà." };

            await _packAssuranceRepo.AddPackAssuranceAsync(packAssurance, AssuranceIds);
            return new PackAssuranceResponse { PackAssurance = packAssurance };
        }

        public async Task<IEnumerable<PackAssurance>?> GetAllPacksAssuranceAsync()
        {
            return await _packAssuranceRepo.GetAllPacksAssuranceAsync();
        }

        public async Task<PackAssuranceResponse> GetPackAssuranceByIdAsync(int id)
        {
            var packAssurance = await _packAssuranceRepo.GetPackAssuranceByIdAsync(id);
            if (packAssurance == null)
                return new PackAssuranceResponse { Message = "PackAssurance non trouvé." };
            return new PackAssuranceResponse { PackAssurance = packAssurance };
        }

        public async Task<PackAssuranceResponse> GetPackAssuranceByNameAsync(string name)
        {
            var packAssurance = await _packAssuranceRepo.GetPackAssuranceByIdName(name);
            if (packAssurance == null)
                return new PackAssuranceResponse { Message = "PackAssurance non trouvé." };
            return new PackAssuranceResponse { PackAssurance = packAssurance };
        }

        public async Task<PackAssuranceResponse> UpdatePackAssuranceAsync(int id, PackAssurance packAssurance, List<int> AssuranceIds)
        {
            var existingPack = await _packAssuranceRepo.GetPackAssuranceByIdAsync(id);
            if (existingPack == null)
                return new PackAssuranceResponse { Message = "PackAssurance non trouvé." };

            await _packAssuranceRepo.UpdatePackAssuranceAsync(packAssurance, AssuranceIds);
            return new PackAssuranceResponse { PackAssurance = packAssurance };
        }

        public async Task<PackAssuranceResponse> DeletePackAssuranceAsync(int id)
        {
            var result = await _packAssuranceRepo.DeletePackAssuranceAsync(id);
            if (result == null)
                return new PackAssuranceResponse { Message = "PackAssurance non trouvé." };
            return new PackAssuranceResponse { Message = "PackAssurance supprimé avec succès." };
        }
    }
}