namespace SGCM.UsesCase.DTOs
{
    public sealed record ReprogramAppointmentDTO
    {
        public int AppointmentId { get; set; }
        public DateTime StartAt {get; set;}
        public DateTime EndAt {get; set;}
    }
}