using SGCM.Entities.Users;

namespace SGCM.UsesCase.Repository
{
    public interface IAutentificationRepository <TEntity>
    {
        Task<TEntity?> LoginAsync(string email, string passwordHash,CancellationToken ct = default);
    }
}