using SGCM.Entities.Appointments;
using SGCM.Entities.Users;

namespace SGCM.Entities.Validators
{
    public static class ValidateCreationUsers
    {
        public static void Validate(Person person)
        {
            BaseValidator.NotNullOrWhiteSpaces(person.FirstName, nameof(person.FirstName), 50);
            BaseValidator.NotNullOrWhiteSpaces(person.LastName, nameof(person.LastName), 50);
            BaseValidator.NotNullOrWhiteSpaces(person.Phone, nameof(person.Phone), 20);
            BaseValidator.NotNullOrWhiteSpaces(person.Email, nameof(person.Email), 50);
            BaseValidator.NotNull(person.PasswordHash, nameof(person.PasswordHash));
            UserValidator.DateOfBirth(person.DateOfBirth, nameof(person.DateOfBirth));
        }
    }
}