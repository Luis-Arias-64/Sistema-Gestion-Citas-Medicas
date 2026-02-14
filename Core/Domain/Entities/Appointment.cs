using SGCM.Domain.Repository;
using SGCM.Domain.Entities.Enum;

namespace SGCM.Domain.Entities
{
    public class Apointment : ApointmentRepository
    {
        private int id_Appointment {get;set;}
        private Doctor Doctor_id {get;set;}
        private Patient Patient_id {get;set;}
        private string Description {get;set;}
        private DateTime ApointmentDate {get;set;}
        private EstateAppointment estateAppointment {get;set;}

        public Apointment(int id_Appointment,Doctor doctor_id, Patient patient_id, DateTime ApointmentDate,string description)
        {
            this.id_Appointment = id_Appointment;
            this.Doctor_id = doctor_id;
            this.Patient_id = patient_id;
            this.ApointmentDate = ApointmentDate;
            this.Description = description;
            this.estateAppointment = EstateAppointment.Pendient;
        }
        public bool ModifiApointMent(int id_Appointment)
        {
            return false;
        }
        public void CancelApointMent(int id_Appointment)
        {
        }
        public Apointment SearchApointment(int id_Appointment)
        {
            return null;
        }

        public string CreateApointMent(Apointment appointment)
        {
            return null;
        }
    }
}