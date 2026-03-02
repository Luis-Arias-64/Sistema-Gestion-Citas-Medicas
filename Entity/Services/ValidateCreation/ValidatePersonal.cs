using SGCM.Entities.Users;
using SGCM.Entities.Validators;

namespace SGCM.Entities.Services
{
    public sealed class ValidatePersonal : ValidateUsers , IValidateUsers
    {
        public void Validate(Personal personal)
        {
            Validate(personal);
        }
    }
}