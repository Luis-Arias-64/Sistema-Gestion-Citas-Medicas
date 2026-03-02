using SGCM.Entities.Users;
using SGCM.Entities.Base;
using SGCM.Entities.Enums;

namespace SGCM.Entities.Appointments
{

    public sealed class Appointment : AuditableEntity<int>
    {
        public int PatientId { get; init; }
        public Patient? Patient { get; init; }

        public int DoctorId { get; init; }
        public Doctor? Doctor { get; init; }

        public int AppointmentStateId {get; init;}
        public AppointmentStatus? AppointmentStatus { get; init; }

        public DateTime AppointmentDate { get; init;}
        public TimeOnly StartAt {get; init;}
        public TimeOnly EndAt {get; init;}
        public Decimal AppointmentCost {get; init;}

    }
}