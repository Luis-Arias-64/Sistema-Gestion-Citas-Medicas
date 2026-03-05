using SGCM.Entities.Users;
using SGCM.Entities.Base;
using SGCM.Entities.Enums;
namespace SGCM.Entities.Appointments
{
    public sealed class Appointment : AuditableEntity<int>
    {
        public int PatientId { get; init; }
        public int DoctorId { get; init; }
        public AppointmentStatus? AppointmentStatus { get; init; }

        public DateTime AppointmentDate { get; init;}
        public DateTime StartAt {get; init;}
        public DateTime EndAt {get; init;}
        public Decimal AppointmentCost {get; init;}
    }
}