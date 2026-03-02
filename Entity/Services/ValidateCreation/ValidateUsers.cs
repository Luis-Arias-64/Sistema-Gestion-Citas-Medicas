using SGCM.Entities.Users;

namespace SGCM.Entities.Validators
{
    public abstract class ValidateUsers : IValidateUsers
    {
        public virtual void Validate(Person person)
        {
            UserBaseValidator.NotNullOrWhiteSpaces(person.FirstName, nameof(person.FirstName), 50);
            UserBaseValidator.NotNullOrWhiteSpaces(person.LastName, nameof(person.LastName), 50);
            UserBaseValidator.NotNullOrWhiteSpaces(person.Phone, nameof(person.Phone), 20);
            UserBaseValidator.NotNullOrWhiteSpaces(person.Email, nameof(person.Email), 50);
            UserBaseValidator.NotNull(person.PasswordHash, nameof(person.PasswordHash));
            UserBaseValidator.DateOfBirth(person.DateOfBirth, nameof(person.DateOfBirth));
        }
    }
}