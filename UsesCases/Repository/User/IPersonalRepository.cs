using SGCM.Entities.Appointments;
using SGCM.Entities.Base;
using SGCM.Entities.Users;

namespace SGCM.UsesCase.Repository
{
    public interface IPersonalRepository : IBaseUsersRepository<Personal, int>
    {
        Task<bool> ConfirmAppointmentStatusAsync(int appointmentId, CancellationToken ct = default);
        Task<IEnumerable<Appointment>> GetAppointmentsAsync (CancellationToken ct = default);
    }
}