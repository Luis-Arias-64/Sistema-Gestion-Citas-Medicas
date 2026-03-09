using SGCM.Entities.Base;

namespace SGCM.Entities.Insurance
{
    public sealed class InsurancePlan : AuditableEntity<short>
    {
        public int InsuranceProviderId {get; set;}
        public string Name {get; set;} = default!;
        public Decimal MaxCovered {get; set;}
    }
}