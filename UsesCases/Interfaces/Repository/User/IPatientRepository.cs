using SGCM.Entities.Insurance;
using SGCM.Entities.Users;

namespace SGCM.UsesCase.Interfaces.Repository
{
    public interface IPatientRepository : IBaseUsersRepository<Patient,int>
    {
        Task<bool> InsurancePlanExistsAsync(short InsurancePlanId);
        Task<bool> IdentificationExitsAsync(string IdentificationNumber);
    }
}