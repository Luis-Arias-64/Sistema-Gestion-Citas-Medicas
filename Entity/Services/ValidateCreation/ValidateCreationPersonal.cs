using SGCM.Entities.Users;
using SGCM.Entities.Validators;

namespace SGCM.Entities.Services
{
    public static class ValidateCreationPersonal
    {
        public static void Validate(Personal personal)
        {
            ValidateCreationUsers.Validate(personal);
        }
    }
}