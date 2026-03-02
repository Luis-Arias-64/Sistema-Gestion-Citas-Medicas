using SGCM.Entities.Users;
using SGCM.Entities.Base;

namespace SGCM.Entities.Appointments
{
    public sealed class DoctorSchedules : AuditableEntity<int>
    {
        public int DoctorId {get; init;}
        public Doctor? Doctor {get; init;}

        public DateOnly ScheduleDate {get; init;}
        public TimeOnly StartAt {get; init;}
        public TimeOnly EndAt {get; init;}
    }
}