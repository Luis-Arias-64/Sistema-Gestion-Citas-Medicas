using SGCM.Entities.Users;
using SGCM.Entities.Validators;

namespace SGCM.Entities.Services
{
    public sealed class ValidatePatient : ValidateUsers, IValidateUsers
    {
        public void Validate(Patient patient)
        {
            Validate(patient);
            UserBaseValidator.ValidateID(patient.InsurancePlanId, nameof(patient.InsurancePlanId));
            UserBaseValidator.NotNullOrWhiteSpaces(patient.IdentificationNumber, nameof(patient.IdentificationNumber),20);
            UserBaseValidator.NotNullOrWhiteSpaces(patient.EmergencyName, nameof(patient.EmergencyName),50);
            UserBaseValidator.NotNullOrWhiteSpaces(patient.EmergencyPhone, nameof(patient.EmergencyPhone),50);
        }
    }
}