using SGCM.Entities.Insurance;
using SGCM.UsesCase.Validators;

namespace SGCM.UsesCase.Factory
{
    public sealed class InsurancePlanFactory
    {
        public InsurancePlan Create(int InsuranceProviderId, string Name, decimal MaxCovered)
        {
            BaseValidator.ValidateID(InsuranceProviderId, nameof(InsuranceProviderId));
            BaseValidator.NotNull(Name, nameof(Name));
            AppointmentValidator.NotZeroMount(MaxCovered, nameof(MaxCovered));

            return new InsurancePlan()
            {
              InsuranceProviderId = InsuranceProviderId,
              Name = Name,
              MaxCovered = MaxCovered  
            };
        }
    }
}