using SGCM.Entities.Appointments;

namespace SGCM.Entities.Validators
{
    public sealed class ValidateAppointment
    {
        public void Validate(Appointment appointment)
        {
            BaseValidator.ValidateID(appointment.Id, nameof(appointment.Id));
            BaseValidator.ValidateID(appointment.PatientId, nameof(appointment.PatientId));
            BaseValidator.ValidateID(appointment.DoctorId, nameof(appointment.DoctorId));
            AppointmentValidator.NotDate(appointment.AppointmentDate, nameof(appointment.AppointmentDate));
            AppointmentValidator.NotOverlap(appointment.StartAt, appointment.EndAt);
            AppointmentValidator.NotZeroMount(appointment.AppointmentCost, nameof(appointment.AppointmentCost));
        }
    }
}