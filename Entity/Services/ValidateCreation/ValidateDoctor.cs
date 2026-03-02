using System.ComponentModel.DataAnnotations;
using SGCM.Entities.Users;
using SGCM.Entities.Validators;

namespace SGCM.Entities.Services
{
    public sealed class ValidateDoctor : ValidateUsers, IValidateUsers
    {
        public void Validate(Personal personal)
        {
            Validate(personal);
        }
    }
}