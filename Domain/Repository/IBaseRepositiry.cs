using System.Linq.Expressions;
using SGCM.Domain.Entities;
using SGCM.Domain.Base;
namespace SGCM.Domain.Repository
{
    public interface IBaseRepository<TEntity> where TEntity :class
    {
        Task<OperationResult> Create(TEntity entity);
        Task<OperationResult> Save(TEntity entity);
        Task<OperationResult> Update(TEntity entity);
        Task<OperationResult> Delete(TEntity entity);
        Task<OperationResult> GetAll();
        Task<OperationResult> Search(int id);
        Task<bool> Exists(TEntity entity);
    }
}