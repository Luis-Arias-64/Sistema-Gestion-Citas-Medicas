using SGCM.Entities.Enums;
using SGCM.Entities.Users;
using SGCM.UsesCase.DTOs;
using SGCM.UsesCase.Validators;

namespace SGCM.UsesCase.Factory
{
    public sealed class PatientFactory
    {    
        public Patient Create(CreatePatientDTO patientDTO)
        {
            ValidateCreationUsers.Validate(patientDTO.FirstName, patientDTO.LastName, patientDTO.Phone, patientDTO.Email, patientDTO.Password, patientDTO.DateOfBirth);
            BaseValidator.ValidateID(patientDTO.InsurancePlanId, nameof(patientDTO.InsurancePlanId));
            BaseValidator.NotNullOrWhiteSpaces(patientDTO.IdentificationNumber, nameof(patientDTO.IdentificationNumber),20);
            BaseValidator.NotNullOrWhiteSpaces(patientDTO.EmergencyName, nameof(patientDTO.EmergencyName),50);
            BaseValidator.NotNullOrWhiteSpaces(patientDTO.EmergencyPhone, nameof(patientDTO.EmergencyPhone),50);

            return new Patient()
            {
              FirstName = patientDTO.FirstName,
              LastName = patientDTO.LastName,
              GenderOfUser = patientDTO.Gender,
              Phone = patientDTO.Phone,
              Email = patientDTO.Email,
              PasswordHash = patientDTO.Password,
              DateOfBirth = patientDTO.DateOfBirth,

              InsurancePlanId = patientDTO.InsurancePlanId,
              IdentificationNumber = patientDTO.IdentificationNumber,
              TypeOfBlood = patientDTO.TypeOfBlood,
              EmergencyName = patientDTO.EmergencyName,
              EmergencyPhone = patientDTO.EmergencyPhone,
            };
        }
    }
}