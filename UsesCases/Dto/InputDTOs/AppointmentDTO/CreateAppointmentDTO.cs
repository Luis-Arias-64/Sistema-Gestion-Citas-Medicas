using SGCM.Entities.Enums;

namespace SGCM.UsesCase.DTOs
{
    public sealed record CreateAppointmentDTO
    {
        public int PatientId { get; init; }
        public int DoctorId {get;set;}
        public DateTime StartAt {get; init;}
        public DateTime EndAt {get; init;}
    }
}