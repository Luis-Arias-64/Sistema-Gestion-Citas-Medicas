using SGCM.Entities.Insurance;
using SGCM.Entities.Users;

namespace SGCM.UsesCase.Repository
{
    public interface IPatientRepository : IBaseUsers<Patient,int>
    {
        Task<bool> ChangeInsurancePlanAsync(InsurancePlan insurancePlan, CancellationToken ct = default);
    }
}