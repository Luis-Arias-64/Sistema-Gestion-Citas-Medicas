using SGCM.Entities.Appointments;
using SGCM.Entities.Enums;
using SGCM.UsesCase.DTOs;
using SGCM.UsesCase.Validators;

namespace SGCM.UsesCase.Factory
{
    public sealed class ValidateAppointment
    {
        public Appointment Create(CreateAppointmentDTO AppointmentDTO)
        {
            BaseValidator.ValidateID(AppointmentDTO.PatientId, nameof(AppointmentDTO.PatientId));
            BaseValidator.ValidateID(AppointmentDTO.DoctorId, nameof(AppointmentDTO.DoctorId));
            AppointmentValidator.NotOverlap(AppointmentDTO.StartAt, AppointmentDTO.EndAt);

            return new Appointment()
            {
                PatientId = AppointmentDTO.PatientId,
                DoctorId = AppointmentDTO.DoctorId,
                AppointmentStatus = AppointmentStatus.Pending,
                StartAt = AppointmentDTO.StartAt,
                EndAt = AppointmentDTO.EndAt,
            };
        }
    }
}