using AssuranceSNTL.Data;
using AssuranceSNTL.Models;
using AssuranceSNTL.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace AssuranceSNTL.Repository.Implementation
{
    public class TypeAssuranceRepo : ITypeAssuranceRepo
    {
        private readonly AppDbContext _context;

        public TypeAssuranceRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TypeAssurance>> GetAllAssurancesAsync()
        {
            return await _context.TypeAssurances.ToListAsync();
        }

        public async Task<IEnumerable<TypeAssurance>> GetAllAssurancesById(int id)
        {
            return await _context.TypeAssurances
                .Where(ta => ta.ID == id)
                .ToListAsync();
        }

        public async Task<IEnumerable<TypeAssurance>> GetAllAssurancesByName(string name)
        {
            return await _context.TypeAssurances
                .Where(ta => ta.Nom.Contains(name))
                .ToListAsync();
        }

        public async Task<IEnumerable<TypeAssurance>> GetAllAssurancesByPrice(decimal price)
        {
            return await _context.TypeAssurances
                .Where(ta => ta.Prix == price)
                .ToListAsync();
        }

        public async Task AddTypeAssuranceAsync(TypeAssurance typeAssurance)
        {
            await _context.TypeAssurances.AddAsync(typeAssurance);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTypeAssuranceAsync(TypeAssurance typeAssurance)
        {
            _context.TypeAssurances.Update(typeAssurance);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteTypeAssuranceAsync(int id)
        {
            var typeAssurance = await _context.TypeAssurances.FindAsync(id);
            if (typeAssurance is null)
            {
                return false;
            }

            _context.TypeAssurances.Remove(typeAssurance);
                await _context.SaveChangesAsync();
            return true;
        }
    }
}
