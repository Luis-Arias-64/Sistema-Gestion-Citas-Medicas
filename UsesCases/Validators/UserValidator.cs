using SGCM.UsesCase.Exceptions;

namespace SGCM.UsesCase.Validators
{
    public static class UserValidator
    {
        public static void DateOfBirth(DateTime date, string fieldName)
        {
            if (date > DateTime.UtcNow)
            {
                throw new InvalidDateOfBirthException($"{fieldName} cannot be in the future.");
            }
        }
        public static void LicenceExpiration(DateTime date,string fieldName)
        {
            if (date > DateTime.Now)
            {
                
            }
        }
    }
}