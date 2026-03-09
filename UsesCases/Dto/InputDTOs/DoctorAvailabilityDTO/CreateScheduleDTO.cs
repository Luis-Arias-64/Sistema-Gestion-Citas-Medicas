namespace SGCM.UsesCase.DTOs
{
    public record CreateScheduleDTO
    {
        public int DoctorId {get; init;}
        public DateTime ScheduleDate {get; init;}
        public DateTime StartAt {get; init;}
        public DateTime EndAt {get; init;}
    }
}