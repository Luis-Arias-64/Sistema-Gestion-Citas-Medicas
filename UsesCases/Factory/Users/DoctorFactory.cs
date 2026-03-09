using SGCM.Entities.Enums;
using SGCM.Entities.Users;
using SGCM.UsesCase.DTOs;
using SGCM.UsesCase.Validators;

namespace SGCM.UsesCase.Factory
{
    public sealed class DoctorFactory
    {
        public Doctor Create(CreateDoctorDTO doctorDTO)
        {
            ValidateCreationUsers.Validate(doctorDTO.FirstName, doctorDTO.LastName, doctorDTO.Phone, doctorDTO.Email, doctorDTO.Password, doctorDTO.DateOfBirth);
            BaseValidator.ValidateID(doctorDTO.EspecialityId, nameof(doctorDTO.EspecialityId));
            BaseValidator.NotNullOrWhiteSpaces(doctorDTO.LicenceNumber, nameof(doctorDTO.LicenceExpiration), 20);
            
            return new Doctor()
            {
                FirstName = doctorDTO.FirstName,
                LastName = doctorDTO.LastName,
                GenderOfUser = doctorDTO.Gender,
                Phone = doctorDTO.Phone,
                Email = doctorDTO.Email,
                PasswordHash = doctorDTO.Password,
                DateOfBirth = doctorDTO.DateOfBirth,
                EspecialityId = doctorDTO.EspecialityId,
                LicenceNumber = doctorDTO.LicenceNumber,
                LicenceExpiration = doctorDTO.LicenceExpiration,
                EmploymentStartDate = doctorDTO.EmploymentStartDate,
            };
        }
    }
}