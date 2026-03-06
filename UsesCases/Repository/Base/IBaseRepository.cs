namespace SGCM.UsesCase.Repository
{
    public interface IBaseRepository<TEntity, Tid>
    {
        Task<TEntity> CreateAsync(TEntity entity, CancellationToken ct = default);
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken ct = default);
        Task<bool> DeleteAsync(Tid value, CancellationToken ct = default);
        Task<TEntity> GetByIdAsync(Tid value, CancellationToken ct = default);
        Task<bool> ExistsAsync(Tid value, CancellationToken ct = default);
    }
}