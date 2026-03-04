using Microsoft.EntityFrameworkCore;
using Medicine.Domain.Repositories;
using Medicine.Persistence.Context;

namespace Medicine.Persistence.Repositories
{
    public class GenericRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly MedicineDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(MedicineDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}