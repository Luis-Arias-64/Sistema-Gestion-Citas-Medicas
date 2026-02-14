using SGCM.Domain.Entities;
using SGCM.Domain.Entities.Enum;

namespace SGCM.Domain.Repository
{
    public interface ApointmentRepository
    {
        public string CreateApointMent(Apointment appointment);
        public bool ModifiApointMent(int id_Appointment);
        public void CancelApointMent(int id_Appointment);
        public Apointment SearchApointment(int id_Appointment);
    }
}