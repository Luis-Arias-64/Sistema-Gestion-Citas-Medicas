using SGCM.Entities.Appointments;
using SGCM.Entities.Enums;
using SGCM.UsesCase.Validators;

namespace SGCM.UsesCase.Factory
{
    public sealed class ValidateAppointment
    {
        public Appointment Create(int PatientId, int DoctorId, DateTime AppointmentDate, DateTime StartAt, DateTime EndAt, 
                            Decimal AppointmentCost)
        {
            BaseValidator.ValidateID(PatientId, nameof(PatientId));
            BaseValidator.ValidateID(DoctorId, nameof(DoctorId));
            AppointmentValidator.NotDate(AppointmentDate, nameof(AppointmentDate));
            AppointmentValidator.NotOverlap(StartAt, EndAt);
            AppointmentValidator.NotZeroMount(AppointmentCost, nameof(AppointmentCost));

            return new Appointment()
            {
                PatientId = PatientId,
                DoctorId = DoctorId,
                AppointmentStatus = AppointmentStatus.Pending,
                AppointmentDate  = AppointmentDate,
                StartAt = StartAt,
                EndAt = EndAt,
                AppointmentCost = AppointmentCost
            };
        }
    }
}