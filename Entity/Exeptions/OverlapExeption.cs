namespace SGCM.Entities.Exceptions
{
    public sealed class OverlapExeption : BaseExeption
    {
        public void OverlapDate()
        {
            Console.WriteLine("The date start date is over the ends date");
        }
    }
}