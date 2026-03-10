using SGCM.Entities.Notifications;

namespace SGCM.UsesCase.Interfaces.Repository
{
    public interface INotificationRepository : IBaseRepository<Notification,int>
    {
        Task<IEnumerable<Notification>> GetNotificationsByPatientAsync(int patientId, CancellationToken ct = default);
        Task<IEnumerable<Notification>> GetNotificationsByDoctorAsync (short doctorId, CancellationToken ct = default);
    }
}