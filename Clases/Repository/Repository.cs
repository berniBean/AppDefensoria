using Clases.ClasesBase;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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

        public  async Task<IQueryable<TEntity>> ObtenerAsync(Expression<Func<TEntity, bool>> entity)
        {
            IQueryable<TEntity> qeryEntidad = entity == null ? _context.Set<TEntity>() : _context.Set<TEntity>().Where(entity);
            return qeryEntidad;
        }

        public async Task<TEntity> ConsultAsync(Expression<Func<TEntity, bool>> Filtro)
        {
            try
            {
                TEntity entidad = await _context.Set<TEntity>().FirstOrDefaultAsync(Filtro);
                return entidad;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
