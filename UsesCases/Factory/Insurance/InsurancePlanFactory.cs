using SGCM.Entities.Insurance;
using SGCM.UsesCase.Validators;

namespace SGCM.UsesCase.Factory
{
    public sealed class InsurancePlanFactory
    {
        public InsurancePlan Create(short InsuranceProviderId, string Name, decimal MaxCovered)
        {
            BaseValidator.ValidateID(InsuranceProviderId, nameof(InsuranceProviderId));
            BaseValidator.NotNull(Name, nameof(Name));

            return new InsurancePlan()
            {
              InsuranceProviderId = InsuranceProviderId,
              Name = Name,
              MaxCovered = MaxCovered  
            };
        }
    }
}