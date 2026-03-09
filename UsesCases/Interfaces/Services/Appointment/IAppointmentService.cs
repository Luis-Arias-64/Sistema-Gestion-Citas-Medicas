using SGCM.Entities.Appointments;

namespace SGCM.UsesCase.Interfaces.Services
{
    public interface IAppointmentService
    {
        Task<IEnumerable<Appointment>> GetAppointmentsByPatientAsync(int patientId, CancellationToken ct =default);
        Task<IEnumerable<Appointment>> GetAppointmentsByDoctorAsync(int doctorId, CancellationToken ct =default);
    }
}