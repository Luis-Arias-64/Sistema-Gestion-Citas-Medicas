using SGCM.Entities.Insurance;

namespace SGCM.Entities.Validators
{
    public class ValidateCreationInsuracePlan
    {   
        public void Validate(InsurancePlan insurancePlan)
        {
            BaseValidator.ValidateID(insurancePlan.Id, nameof(insurancePlan.Id));
            BaseValidator.ValidateID(insurancePlan.InsuranceProviderId, nameof(insurancePlan.InsuranceProviderId));
            BaseValidator.NotNull(insurancePlan.Name, nameof(insurancePlan.Name));
            AppointmentValidator.NotZeroMount(insurancePlan.MaxCovered, nameof(insurancePlan.MaxCovered));
        }
    }
}