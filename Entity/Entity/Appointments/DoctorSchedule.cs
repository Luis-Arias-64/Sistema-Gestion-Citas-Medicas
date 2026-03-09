using SGCM.Entities.Users;
using SGCM.Entities.Base;

namespace SGCM.Entities.Appointments
{
    public sealed class DoctorSchedules : AuditableEntity<int>
    {
        public int DoctorId {get; set;}
        public DateTime ScheduleDate {get; set;}
        public DateTime StartAt {get; set;}
        public DateTime EndAt {get; set;}
    }
}