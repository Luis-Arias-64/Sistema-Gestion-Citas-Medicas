using SGCM.Entities.Users;
using SGCM.Entities.Validators;

namespace SGCM.Entities.Services
{
    public static class ValidateCreationPatient
    {
        public static void Validate(Patient patient)
        {
            ValidateCreationUsers.Validate(patient);
            BaseValidator.ValidateID(patient.InsurancePlanId, nameof(patient.InsurancePlanId));
            BaseValidator.NotNullOrWhiteSpaces(patient.IdentificationNumber, nameof(patient.IdentificationNumber),20);
            BaseValidator.NotNullOrWhiteSpaces(patient.EmergencyName, nameof(patient.EmergencyName),50);
            BaseValidator.NotNullOrWhiteSpaces(patient.EmergencyPhone, nameof(patient.EmergencyPhone),50);
        }
    }
}