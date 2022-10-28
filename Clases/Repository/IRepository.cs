namespace Clases.Repository
{
    public interface IRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetASync();
        Task<TEntity> GetAsync(string Id);
        Task AddAsync(TEntity data);
        Task DeleteAsync(string Id);
        void Upadate(TEntity data);
        Task<int> SaveAsync();
    }
}
