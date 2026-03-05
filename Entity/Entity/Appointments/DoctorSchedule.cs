using SGCM.Entities.Users;
using SGCM.Entities.Base;

namespace SGCM.Entities.Appointments
{
    public sealed class DoctorSchedules : AuditableEntity<int>
    {
        public int DoctorId {get; init;}

        public DateTime ScheduleDate {get; init;}
        public DateTime StartAt {get; init;}
        public DateTime EndAt {get; init;}
    }
}