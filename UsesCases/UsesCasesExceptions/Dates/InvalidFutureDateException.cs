namespace SGCM.UsesCase.Exceptions
{
    public sealed class InvalidFutureDate   : BaseExeption
    {
        public InvalidFutureDate(string message) : base(message)
        {
        }
    }
}