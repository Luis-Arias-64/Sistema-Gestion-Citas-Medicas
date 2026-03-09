using SGCM.Entities.Appointments;
using SGCM.UsesCase.DTOs;
using SGCM.UsesCase.Validators;

namespace SGCM.UsesCase.Factory
{
    public sealed class ValidateCreationDoctorSchedule
    {
        public DoctorSchedules Create(CreateScheduleDTO createScheduleDTO)
        {
            BaseValidator.ValidateID(createScheduleDTO.DoctorId, nameof(createScheduleDTO.DoctorId));
            BaseValidator.NotNull(createScheduleDTO.ScheduleDate, nameof(createScheduleDTO.ScheduleDate));
            AppointmentValidator.NotOverlap(createScheduleDTO.StartAt, createScheduleDTO.EndAt);

            return new DoctorSchedules()
            {
                DoctorId = createScheduleDTO.DoctorId,
                ScheduleDate = createScheduleDTO.ScheduleDate,
                StartAt = createScheduleDTO.StartAt,
                EndAt = createScheduleDTO.EndAt
            };
        }
    }
}