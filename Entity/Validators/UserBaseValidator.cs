using System.ComponentModel.DataAnnotations;
using SGCM.Entities.Enums;
using SGCM.Entities.Exceptions;

namespace SGCM.Entities.Validators
{
    public static class UserBaseValidator
    {
        public static void NotNull<TValue>(TValue Value, string fieldName){
            if(Value is null)
            {
                throw new InvalidNullException($"{fieldName} cannot be null");
            }
        }
        public static void DateOfBirth(DateTime date, string fieldName)
        {
            if (date > DateTime.UtcNow)
            {
                throw new InvalidDateOfBirthException($"{fieldName} cannot be in the future.");
            }
        }

        public static void ValidateID(int Id, string fieldName)
        {
            if(Id < 1)
            {
                throw new InvalidIDException($"{fieldName} cannot has an id minor or equal 0");
            }
        }

        public static void NotNullOrWhiteSpaces(string value, string fieldName, int maxSpace)
        {
            if (value is null)
            {
                throw new InvalidNullException($"{fieldName} cannot be null");
            }
            if (value.Length > maxSpace)
            {
                throw new InvalidWhiteException($"{fieldName} has to much arguments");
            }
        }
    }
}