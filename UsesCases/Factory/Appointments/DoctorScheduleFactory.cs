using SGCM.Entities.Appointments;
using SGCM.UsesCase.Validators;

namespace SGCM.UsesCase.Factory
{
    public sealed class ValidateCreationDoctorSchedule
    {
        public DoctorSchedules Create(int DoctorId, DateTime ScheduleDate, DateTime StartAt, DateTime EndAt)
        {
            BaseValidator.ValidateID(DoctorId, nameof(DoctorId));
            BaseValidator.NotNull(ScheduleDate, nameof(ScheduleDate));
            AppointmentValidator.NotOverlap(StartAt, EndAt);

            return new DoctorSchedules()
            {
                DoctorId = DoctorId,
                ScheduleDate = ScheduleDate,
                StartAt = StartAt,
                EndAt = EndAt
            };
        }
    }
}