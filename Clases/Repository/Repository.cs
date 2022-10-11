using Clases.ClasesBase;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Clases.Repository
{
    public class Repository<TEntity> : HandlerRequestBase, IRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> _dbSet;
        public Repository(ednita_dbContext context) : base(context)
        {
            _dbSet = _context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity data) => await _dbSet.AddAsync(data);

        public async Task DeleteAsync(string Id)
        {
            var dtaDelete = await _dbSet.FindAsync(Id);
            _dbSet.Remove(dtaDelete);
        }
        public async Task<IEnumerable<TEntity>> GetASync() => await _dbSet.ToListAsync();


        public async Task<TEntity> GetAsync(string Id) => await _dbSet.FindAsync(Id);



        public void Upadate(TEntity data)
        {
            var update = _dbSet.Attach(data);
            _context.Entry(data).State = EntityState.Modified;
        }


        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();


    }
}
