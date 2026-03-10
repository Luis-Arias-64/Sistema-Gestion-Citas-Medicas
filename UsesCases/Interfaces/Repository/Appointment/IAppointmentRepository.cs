using SGCM.Entities.Appointments;

namespace SGCM.UsesCase.Repository
{
    public interface IAppointmentRepository : IBaseRepository<Appointment,int>
    {
        Task<IEnumerable<Appointment>> GetAppointmentByDateAsync(DateTime dateTime, CancellationToken ct = default);
        Task<bool> CancelAppointmentAsync(int AppointmentId, DateTime day, CancellationToken ct = default);
        Task<bool> ReprogramAppointmentAsync(int AppointmentId, DateTime day, DateTime newHour, CancellationToken ct = default);
        Task<IEnumerable<Appointment>> GetAppointmentsByPatientAsync(int patientId, CancellationToken ct =default);
        Task<IEnumerable<Appointment>> GetAppointmentsByDoctorAsync(int doctorId, CancellationToken ct =default);
    }
}