using Medicine.Domain.Repositories;
using Medicine.Persistence.Context;

namespace Medicine.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MedicineDbContext _context;

        public UnitOfWork(MedicineDbContext context)
        {
            _context = context;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}