using SGCM.Entities.Insurance;
using SGCM.UsesCase.DTOs;
using SGCM.UsesCase.Validators;

namespace SGCM.UsesCase.Factory
{
    public sealed class InsurancePlanFactory
    {
        public InsurancePlan Create(CreateInsurancePlanDTO createInsurancePlanDTO)
        {
            BaseValidator.ValidateID(createInsurancePlanDTO.InsuranceProviderId, nameof(createInsurancePlanDTO.InsuranceProviderId));
            BaseValidator.NotNull(createInsurancePlanDTO.Name, nameof(createInsurancePlanDTO.Name));

            return new InsurancePlan()
            {
              InsuranceProviderId = createInsurancePlanDTO.InsuranceProviderId ,
              Name = createInsurancePlanDTO.Name,
            };
        }
    }
}