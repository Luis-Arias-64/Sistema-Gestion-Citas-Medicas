namespace SGCM.Domain.BussinesServices
{
    public interface IAppointmentConflictValidator
    {
        Task ValidateConflictAsync(Guid doctorId, DateTime dateTime);
    }
}