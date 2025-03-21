using AssuranceSNTL.Data;
using AssuranceSNTL.Models;
using AssuranceSNTL.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace AssuranceSNTL.Repository.Implementation
{
    public class PackAssuranceRepo : IPackAssuranceRepo
    {
        private readonly AppDbContext _context;

        public PackAssuranceRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PackAssurance>> GetAllPacksAssuranceAsync()
        {
            return await _context.PackAssurances
                .Include(pa => pa.PackTypeAssurances)
                .ThenInclude(pta => pta.TypeAssurance)
                .ToListAsync();
        }

        public async Task<PackAssurance> GetPackAssuranceByIdAsync(int id)
        {
            return await _context.PackAssurances
                .Include(pa => pa.PackTypeAssurances)
                .ThenInclude(pta => pta.TypeAssurance)
                .FirstOrDefaultAsync(pa => pa.ID == id);
        }

        public async Task<PackAssurance> GetPackAssuranceByIdName(string name)
        {
            return await _context.PackAssurances
                .Include(pa => pa.PackTypeAssurances)
                .ThenInclude(pta => pta.TypeAssurance)
                .FirstOrDefaultAsync(pa => pa.Nom == name);
        }

        public async Task AddPackAssuranceAsync(PackAssurance packAssurance, List<int> AssuranceIds)
        {
            await _context.PackAssurances.AddAsync(packAssurance);
            await _context.SaveChangesAsync();

            foreach (var assuranceId in AssuranceIds)
            {
                var packTypeAssurance = new PackTypeAssurance
                {
                    PackAssuranceID = packAssurance.ID,
                    TypeAssuranceID = assuranceId
                };
                await _context.PackTypeAssurances.AddAsync(packTypeAssurance);
            }

            await _context.SaveChangesAsync();
        }

        public async Task UpdatePackAssuranceAsync(PackAssurance packAssurance, List<int> AssuranceIds)
        {
            _context.PackAssurances.Update(packAssurance);

            var existingRelations = await _context.PackTypeAssurances
                .Where(pta => pta.PackAssuranceID == packAssurance.ID)
                .ToListAsync();
            _context.PackTypeAssurances.RemoveRange(existingRelations);

            foreach (var assuranceId in AssuranceIds)
            {
                var packTypeAssurance = new PackTypeAssurance
                {
                    PackAssuranceID = packAssurance.ID,
                    TypeAssuranceID = assuranceId
                };
                await _context.PackTypeAssurances.AddAsync(packTypeAssurance);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeletePackAssuranceAsync(int id)
        {
            var packAssurance = await _context.PackAssurances
                .Include(pa => pa.PackTypeAssurances)
                .FirstOrDefaultAsync(pa => pa.ID == id);

            if (packAssurance is null) {
                return false;
            }
           
                _context.PackTypeAssurances.RemoveRange(packAssurance.PackTypeAssurances);

                _context.PackAssurances.Remove(packAssurance);
                await _context.SaveChangesAsync();
                return true;
            
        }
    }
}