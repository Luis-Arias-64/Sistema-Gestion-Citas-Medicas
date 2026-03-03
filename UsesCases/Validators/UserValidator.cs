using SGCM.Entities.Exceptions;
namespace SGCM.Entities.Appointments
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
    }
}