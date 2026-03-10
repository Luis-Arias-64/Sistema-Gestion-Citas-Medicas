namespace SGCM.UsesCase.Repository
{
    public interface IBaseRepository<TEntity, Tid>
    {
        Task<TEntity> AddAsync(TEntity entity, CancellationToken ct = default);
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken ct = default);
        Task<bool> DeleteAsync(Tid value, CancellationToken ct = default);
        Task<TEntity> GetByIdAsync(Tid value, CancellationToken ct = default);
        Task<IEnumerable<TEntity>> GetAllAsync(TEntity entity);
        Task<bool> ExistsAsync(Tid value, CancellationToken ct = default); 
    }
}