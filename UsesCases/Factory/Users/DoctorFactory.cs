using System.ComponentModel.DataAnnotations;
using SGCM.Entities.Enums;
using SGCM.Entities.Users;
using SGCM.UsesCase.Validators;

namespace SGCM.UsesCase.Factory
{
    public sealed class DoctorFactory
    {
        public Doctor Create(string FirstName, string LastName, string Phone, string Email, string PasswordHash, DateTime DateOfBirth,short EspecialityId, 
                               string LicenceNumber, DateTime LicenceExpiration, DateTime EmploymentStartDate)
        {
            ValidateCreationUsers.Validate(FirstName, LastName,Phone,Email,PasswordHash,DateOfBirth);
            BaseValidator.ValidateID(EspecialityId, nameof(EspecialityId));
            BaseValidator.NotNullOrWhiteSpaces(LicenceNumber, nameof(LicenceNumber), 20);
            
            return new Doctor()
            {
                FirstName = FirstName,
                LastName = LastName,
                Phone = Phone,
                Email = Email,
                PasswordHash = PasswordHash,
                DateOfBirth = DateOfBirth,
                EspecialityId = EspecialityId,
                LicenceNumber = LicenceNumber,
                LicenceExpiration = LicenceExpiration,
                EmploymentStartDate = EmploymentStartDate,
                typeUser = TypeUser.Doctor
            };
        }
    }
}