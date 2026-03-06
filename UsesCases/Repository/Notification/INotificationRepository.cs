using SGCM.Entities.Notifications;
using SGCM.UsesCase.Repository;

namespace SGCM.UsesCase.Validators
{
    public interface INotificationRepository : IBaseRepository<Notification,int>
    {
        Task<IEnumerable<Notification>> GetNotificationsByPatientAsync(int patientId, CancellationToken ct = default);
        Task<IEnumerable<Notification>> GetNotificationsByDoctorAsync (short doctorId, CancellationToken ct = default);
    }
}