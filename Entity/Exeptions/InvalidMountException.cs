namespace SGCM.Entities.Exceptions
{
    public sealed class InvalidMountException : BaseExeption
    {
        public void ZeroMount()
        {
            Console.WriteLine("The mount can't be less o equal zero");
        }
    }
}