using SGCM.UsesCase.Exceptions;

namespace SGCM.UsesCase.Validators
{
    public static class AppointmentValidator 
    {
        public static void NotOverlap(DateTime StartAt, DateTime EndAt)
        {
            if (StartAt > EndAt)
            {
                throw new InvalidOverlapExeption("The start date is over the end Date");
            }
        }
        public static void NotDate(DateTime dateTime, string FieldName)
        {
            if (dateTime < DateTime.UtcNow)
            {
                throw new InvalidFutureDate($"{FieldName} The Date isnt posible");
            }
        }
    }
}