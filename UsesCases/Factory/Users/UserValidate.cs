using SGCM.Entities.Appointments;
using SGCM.Entities.Enums;
using SGCM.Entities.Users;
using SGCM.UsesCase.Validators;

namespace SGCM.UsesCase.Factory
{
    public static class ValidateCreationUsers
    {
        public static void Validate(string FirstName, string LastName, string Phone, string Email, string PasswordHash, DateTime DateOfBith)
        {
            BaseValidator.NotNullOrWhiteSpaces(FirstName, nameof(FirstName), 50);
            BaseValidator.NotNullOrWhiteSpaces(LastName, nameof(LastName), 50);
            BaseValidator.NotNullOrWhiteSpaces(Phone, nameof(Phone), 20);
            BaseValidator.NotNullOrWhiteSpaces(Email, nameof(Email), 50);
            BaseValidator.NotNull(Email, nameof(Email));
            BaseValidator.NotNull(PasswordHash, nameof(PasswordHash));
            UserValidator.DateOfBirth(DateOfBith, nameof(DateOfBith));
        }
    }
}