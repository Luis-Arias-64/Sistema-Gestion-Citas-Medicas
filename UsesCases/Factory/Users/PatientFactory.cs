using SGCM.Entities.Enums;
using SGCM.Entities.Users;
using SGCM.UsesCase.Validators;

namespace SGCM.UsesCase.Factory
{
    public sealed class PatientFactory
    {    
        public Patient Create(string FirstName, string LastName, string Phone, string Email, string PasswordHash, DateTime DateOfBirth, short InsurancePlanId, 
                            string IdentificationNumber, BloodType TypeOfBlood, string EmergencyName, string EmergencyPhone)
        {
            ValidateCreationUsers.Validate(FirstName,LastName,Phone,Email,PasswordHash,DateOfBirth);
            BaseValidator.ValidateID(InsurancePlanId, nameof(InsurancePlanId));
            BaseValidator.NotNullOrWhiteSpaces(IdentificationNumber, nameof(IdentificationNumber),20);
            BaseValidator.NotNullOrWhiteSpaces(EmergencyName, nameof(EmergencyName),50);
            BaseValidator.NotNullOrWhiteSpaces(EmergencyPhone, nameof(EmergencyPhone),50);

            return new Patient()
            {
              FirstName = FirstName,
              LastName = LastName,
              Phone = Phone,
              Email = Email,
              PasswordHash = PasswordHash,
              DateOfBirth = DateOfBirth,
              InsurancePlanId = InsurancePlanId,
              IdentificationNumber = IdentificationNumber,
              TypeOfBlood =  TypeOfBlood,
              EmergencyName = EmergencyName,
              EmergencyPhone = EmergencyPhone,
              typeOfUser = TypeUser.Patient
            };
        }
    }
}