using SGCM.Entities.Enums;
using SGCM.Entities.Users;
using SGCM.UsesCase.DTOs;

namespace SGCM.UsesCase.Factory
{
    public sealed class PersonalFactory
    {
        public Personal Create(CreatePersonalDTO personalDTO)
        {
            ValidateCreationUsers.Validate(personalDTO.FirstName, personalDTO.LastName, personalDTO.Phone, personalDTO.Email, personalDTO.Password, personalDTO.DateOfBirth);

            return new Personal()
            {
                FirstName = personalDTO.FirstName,
                LastName = personalDTO.LastName,
                GenderOfUser = personalDTO.Gender,
                Phone = personalDTO.Phone,
                Email = personalDTO.Email,
                PasswordHash = personalDTO.Password,
                DateOfBirth = personalDTO.DateOfBirth,
                Role = personalDTO.Role
            };
        }
    }
}