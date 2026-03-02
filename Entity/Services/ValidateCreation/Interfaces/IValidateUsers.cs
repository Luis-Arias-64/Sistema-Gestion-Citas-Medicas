using SGCM.Entities.Users;

namespace SGCM.Entities.Validators
{
    public interface IValidateUsers
    {
        public void Validate(Person entity);
    }
}