namespace SGCM.Entities.Validators
{
    public abstract class BaseValidator
    {
        protected string FieldName {get; init;}

        public BaseValidator(string FieldName)
        {
            this.FieldName = FieldName;
        }
    }
}