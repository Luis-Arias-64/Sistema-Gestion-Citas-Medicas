namespace SGCM.UsesCase.Exceptions
{
    public sealed class InvalidNullException : BaseExeption
    {
        public InvalidNullException(string message) : base(message)
        {
        }
    }
}