using SGCM.Entities.Insurance;

namespace SGCM.Entities.Validators
{
    public class ValidateCreationInsuranceProvider
    {
        public void Validate(InsuranceProvider insurance)
        {
            BaseValidator.ValidateID(insurance.Id, nameof(insurance.Id));
            BaseValidator.NotNull(insurance.Name, nameof(insurance.Name));
            BaseValidator.NotNull(insurance.Phone, nameof(insurance.Phone));
            BaseValidator.NotNull(insurance.Email, nameof(insurance.Email));
            BaseValidator.NotNull(insurance.Address, nameof(insurance.Address));
            BaseValidator.NotNull(insurance.City, nameof(insurance.City));
            BaseValidator.NotNull(insurance.ContanctCenter, nameof(insurance.ContanctCenter));
        }
    }
}