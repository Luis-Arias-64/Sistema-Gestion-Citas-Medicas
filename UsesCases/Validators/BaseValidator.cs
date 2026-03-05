using SGCM.UsesCase.Exceptions;

namespace SGCM.UsesCase.Validators
{
    public static class BaseValidator
    {
        public static void NotNull<TValue>(TValue Value, string FieldName){
            if(Value is null)
            {
               throw new InvalidNullException($"{FieldName}: Cannot be null");
            }
        }
        public static void ValidateID(int Id, string FieldName)
        {
            if(Id < 1)
            {
                throw new InvalidIDException($"{FieldName}: Cannot has an id minor or equal 0");
            }
        }
        public static void NotNullOrWhiteSpaces(string value, string FieldName, int maxSpace)
        {
            if (value is null)
            {
                throw new InvalidNullException($"{FieldName}: Cannot be null");
            }
            if (value.Length > maxSpace)
            {
                throw new InvalidWhiteException($"{FieldName}: Has to much arguments");
            }
        }
    }
}