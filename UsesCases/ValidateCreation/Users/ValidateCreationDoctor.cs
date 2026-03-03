using System.ComponentModel.DataAnnotations;
using SGCM.Entities.Users;
using SGCM.Entities.Validators;

namespace SGCM.Entities.Services
{
    public static class ValidateDoctor
    {
        public static void Validate(Doctor doctor)
        {
            ValidateCreationUsers.Validate(doctor);
            BaseValidator.ValidateID(doctor.EspecialityId, nameof(doctor.EspecialityId));
            BaseValidator.NotNullOrWhiteSpaces(doctor.LicenceNumber, nameof(doctor.LicenceNumber), 20);
        }
    }
}