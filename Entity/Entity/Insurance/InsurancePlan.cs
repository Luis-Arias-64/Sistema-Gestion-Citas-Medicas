using SGCM.Entities.Base;

namespace SGCM.Entities.Insurance
{
    public sealed class InsurancePlan : AuditableEntity<short>
    {
        public int InsuranceProviderId {get; init;}
        public string? Name {get; init;}
        public Decimal MaxCovered {get; init;}
    }
}