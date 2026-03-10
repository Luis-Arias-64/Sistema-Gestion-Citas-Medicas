using SGCM.Entities.Enums;
using SGCM.Entities.Users;
using SGCM.UsesCase.DTOs;

namespace SGCM.UsesCase.Factory
{
    public static class PersonalFactory
    {
        public static Personal Create(CreatePersonalDTO personalDTO)
        {
            ValidateCreationUsers.Validate(personalDTO.FirstName, personalDTO.LastName, personalDTO.Phone, personalDTO.Email, personalDTO.Password, personalDTO.DateOfBirth);

            return new Personal()
            {
                FirstName = personalDTO.FirstName,
                LastName = personalDTO.LastName,
                Gender = personalDTO.Gender,
                Phone = personalDTO.Phone,
                Email = personalDTO.Email,
                Password = personalDTO.Password,
                DateOfBirth = personalDTO.DateOfBirth,
                Role = personalDTO.Role
            };
        }
    }
}