namespace SGCM.UsesCase.Exceptions
{
    public sealed class InvalidIDException : BaseExeption
    {
        public InvalidIDException(string message) : base(message)
        {
        }
    }
}