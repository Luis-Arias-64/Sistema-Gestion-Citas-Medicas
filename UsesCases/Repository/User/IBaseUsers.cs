using SGCM.Entities.Users;

namespace SGCM.UsesCase.Repository
{
    public interface IBaseUsers<TEntity, Tid> : IBaseRepository<TEntity, Tid>
    {
        Task<bool> EmailExistsAsync(string email, CancellationToken ct = default);
        Task<TEntity?> GetByEmailAsync(string email, CancellationToken ct = default);
        Task<TEntity> UpdatePasswordAsync(Tid id, string password, CancellationToken ct = default);
    }
}