using SGCM.Entities.Enums;
using SGCM.Entities.Users;
using SGCM.UsesCase.DTOs;
using SGCM.UsesCase.Validators;

namespace SGCM.UsesCase.Factory
{
    public static class DoctorFactory
    {
        public static Doctor Create(CreateDoctorDTO doctorDTO)
        {
            ValidateCreationUsers.Validate(doctorDTO.FirstName, doctorDTO.LastName, doctorDTO.Phone, doctorDTO.Email, doctorDTO.Password, doctorDTO.DateOfBirth);
            BaseValidator.ValidateID(doctorDTO.EspecialityId, nameof(doctorDTO.EspecialityId));
            BaseValidator.NotNullOrWhiteSpaces(doctorDTO.LicenceNumber, nameof(doctorDTO.LicenceExpiration), 20);
            
            return new Doctor()
            {
                FirstName = doctorDTO.FirstName,
                LastName = doctorDTO.LastName,
                Gender = doctorDTO.Gender,
                Phone = doctorDTO.Phone,
                Email = doctorDTO.Email,
                Password = doctorDTO.Password,
                DateOfBirth = doctorDTO.DateOfBirth,
                EspecialityId = doctorDTO.EspecialityId,
                LicenceNumber = doctorDTO.LicenceNumber,
                LicenceExpiration = doctorDTO.LicenceExpiration,
                EmploymentStartDate = doctorDTO.EmploymentStartDate,
            };
        }
    }
}