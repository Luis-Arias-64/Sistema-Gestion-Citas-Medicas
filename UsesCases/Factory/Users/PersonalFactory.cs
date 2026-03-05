using SGCM.Entities.Enums;
using SGCM.Entities.Users;

namespace SGCM.UsesCase.Factory
{
    public sealed class PersonalFactory
    {
        public Personal Create(string FirstName, string LastName, string Phone, string Email, string PasswordHash, DateTime DateOfBirth, Rolename RolName)
        {
            ValidateCreationUsers.Validate(FirstName,LastName,Phone,Email,PasswordHash,DateOfBirth);

            return new Personal()
            {
                FirstName = FirstName,
                LastName = LastName,
                Phone = Phone,
                Email = Email,
                PasswordHash = PasswordHash,
                DateOfBirth = DateOfBirth,
                Role = RolName 
            };
        }
    }
}