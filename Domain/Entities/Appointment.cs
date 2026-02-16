using SGCM.Domain.Enum;
using SGCM.Domain.Exeptions;

namespace SGCM.Domain.Entities
{
    public class Appointment
    {
        public Guid Id { get; private set; }
        public Guid PatientID { get; private set; }
        public Guid DoctorID { get; private set; }
        public Guid EspecialityID { get; private set; }

        public DateTime DateAppointment { get; private set; }
        public EstateAppointment Estate { get; private set; }

        public DateTime DateCreation { get; private set; }

        private Appointment() { }

        public Appointment(Guid PatientID, Guid DoctorID, Guid EspecialityID, DateTime DateAppointment)
        {
            if (DateAppointment <= DateTime.UtcNow)
            {
                throw new BussinesException("La fecha de la cita debe ser futura");
            }

            Id = Guid.NewGuid();
            this.PatientID = PatientID;
            this.DoctorID = DoctorID;
            this.EspecialityID = EspecialityID;
            this.DateAppointment = DateAppointment;
            this.Estate = EstateAppointment.Pending;
            this.DateCreation = DateTime.UtcNow;
        }

        public void Confirm()
        {
            if (Estate != EstateAppointment.Pending)
                throw new BussinesException("Solo citas pendientes pueden confirmarse");

            Estate = EstateAppointment.Confirm;
        }

        public void Cancel()
        {
            if (Estate == EstateAppointment.Completed)
                throw new BussinesException("No se puede cancelar una cita realizad");

            Estate = EstateAppointment.Cancel;
        }

        public void MarcarComoRealizada()
        {
            if (Estate != EstateAppointment.Confirm)
                throw new BussinesException("Solo citas confirmadas pueden marcarse como ealizadas");

            Estate = EstateAppointment.Completed;
        }

        public void Reprogramar(DateTime NewDate)
        {
            if (Estate == EstateAppointment.Cancel || Estate == EstateAppointment.Completed)
                throw new BussinesException("No se puede reproramar esta cita.");

            if (DateAppointment <= DateTime.UtcNow)
                throw new BussinesException("La nueva fecha debe ser futura.");

            DateAppointment = NewDate;
            Estate = EstateAppointment.Pending;
        }
    }
}