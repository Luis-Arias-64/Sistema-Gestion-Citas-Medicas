using SGCM.Entities.Insurance;
using SGCM.UsesCase.Repository;

namespace SGCM.UsesCase.Validators
{
    public interface IInsurancePlanProviderRepository : IBaseRepository<InsurancePlan,short>
    {
        Task<bool> ModifyCoveredPlanAsync(int insurancePlan, decimal newCovered, CancellationToken ct = default);
    }
}