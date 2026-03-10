namespace SGCM.UsesCase.Interfaces.Repository
{
    public interface IBaseUsersRepository<TEntity, TId> : IBaseRepository<TEntity, TId>
    {
        Task<bool> EmailExistsAsync(string email, CancellationToken ct = default);
        Task<TEntity?> GetByEmailAsync(string email, CancellationToken ct = default);
        Task<TEntity> UpdatePasswordAsync(TId id, string password, CancellationToken ct = default);
        Task<bool> IsActiveAsync(TId id, CancellationToken ct = default);
    }
}