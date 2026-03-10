namespace SGCM.UsesCase.Interfaces.Logger
{
    public interface IBaseLogger<TEntity>
    { 
        Task LogInformationAsync(string message);
        Task LogWarningAsync(string message);
        Task LogErrorAsync(string message);
        Task LogErrorAsync(string message, Exception exception);        
    }
}