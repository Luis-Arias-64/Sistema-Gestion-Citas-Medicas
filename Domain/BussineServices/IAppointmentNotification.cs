using SGCM.Domain.Entities;

namespace SGCM.Domain.BussinesServices
{
    public interface IAppointmentNotifier
    {
        Task NotifyConfirmationAsync(Appointment appointment);
        Task NotifyCancellationAsync(Appointment appointment);
    }
}