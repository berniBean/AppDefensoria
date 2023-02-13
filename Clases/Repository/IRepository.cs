using System.Linq.Expressions;

namespace Clases.Repository
{
    public interface IRepository<TEntity>
    {
        Task<IQueryable<TEntity>> ObtenerAsync(Expression<Func<TEntity,bool>> entity);
        Task<TEntity> ConsultAsync(Expression<Func<TEntity, bool>> Filtro);
        Task<IEnumerable<TEntity>> GetASync();
        Task<TEntity> GetAsync(string Id);
        Task AddAsync(TEntity data);
        Task DeleteAsync(string Id);
        void Upadate(TEntity data);
        Task<int> SaveAsync();
    }
}
