using SGCM.Entities.Exceptions;

namespace SGCM.Entities.Validators
{
    public static class AppointmentValidator 
    {
        public static void NotZeroMount(decimal mount, string FieldName)
        {
            if (mount < 0)
            {
                throw new InvalidMountException($"{FieldName}: the mount cannot be less that zero");
            }
        }
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