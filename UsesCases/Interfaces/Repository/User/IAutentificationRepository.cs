namespace SGCM.UsesCase.Interfaces.Repository
{
    public interface IAutentificationRepository <TEntity>
    {
        Task<TEntity?> LoginAsync(string email, string passwordHash,CancellationToken ct = default);
    }
}