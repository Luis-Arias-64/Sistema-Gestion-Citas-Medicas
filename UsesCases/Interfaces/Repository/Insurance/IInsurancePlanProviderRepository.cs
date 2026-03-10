using SGCM.Entities.Insurance;

namespace SGCM.UsesCase.Interfaces.Repository
{
    public interface IInsurancePlanProviderRepository : IBaseRepository<InsurancePlan,short>
    {
        Task<bool> ModifyCoveredPlanAsync(int insurancePlan, decimal newCovered, CancellationToken ct = default);
    }
}