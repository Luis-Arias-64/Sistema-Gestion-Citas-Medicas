using SGCM.Entities.Users;
using SGCM.Entities.Base;
using SGCM.Entities.Enums;
namespace SGCM.Entities.Appointments
{
    public sealed class Appointment : AuditableEntity<int>
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public AppointmentStatus AppointmentStatus { get; set; }
        public DateTime AppointmentDate { get; set;}
        public DateTime StartAt {get; set;}
        public DateTime EndAt {get; set;}
        public Decimal AppointmentCost {get; set;}
    }
}