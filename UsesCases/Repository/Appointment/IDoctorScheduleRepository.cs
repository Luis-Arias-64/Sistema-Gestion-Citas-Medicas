using SGCM.UsesCase.Repository;

namespace SGCM.UsesCase.Validators
{
    public interface DoctorScheduleRepository : IBaseRepository<DoctorScheduleRepository, int>
    {
        Task<bool> CancelScheduleAsync(int scheduleId, CancellationToken ct = default );
        Task<bool> RescheduleAppointmentAsync(int scheduleId, DateTime oldDay, DateTime oldHour, DateTime? newDay, DateTime? newHour, CancellationToken ct = default);
    }
}