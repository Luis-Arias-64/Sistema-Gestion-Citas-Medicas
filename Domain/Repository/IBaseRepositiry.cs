using System.Linq.Expressions;
using SGCM.Domain.Entities;
using SGCM.Domain.Base;
namespace SGCM.Domain.Repository
{
    public interface IBaseRepository<TEntity> where TEntity :class
    {
        Task<OperationResult> CreateUser(TEntity entity);
        Task<OperationResult> SaveUser(TEntity entity);
        Task<OperationResult> UpdateUser(TEntity entity);
        Task<OperationResult> DeleteUser(TEntity entity);
        Task<OperationResult> GetAllUser();
        Task<OperationResult> SearchUser(int id);
        Task<bool> UserExists(TEntity entity);
    }
}