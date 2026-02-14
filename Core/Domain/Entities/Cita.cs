using SGCM.Domain.Entities.Enum;
namespace SGCM.Domain.Entities
{
    public class Cita
    {
        private Doctor doctor {get;set;}
        private Patient patient {get;set;}
        private DateTime dateInto {get;set;}
        private DateTime dateExit {get;set;}
        private string description {get;set;}
        private EstateAppointment estateAppointment {get;set;}
        public Cita(Doctor doctor, Patient patient, DateTime dateInto, DateTime dateExit, string description){
            this.doctor = doctor;
            this.patient = patient;
            this.dateInto = dateInto;
            this.dateExit = dateExit;
            this.description = description;
            this.estateAppointment = EstateAppointment.Confirm;
        }
    }
}