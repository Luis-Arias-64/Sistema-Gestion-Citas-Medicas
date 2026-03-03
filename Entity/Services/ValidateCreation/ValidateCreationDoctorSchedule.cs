using SGCM.Entities.Appointments;

namespace SGCM.Entities.Validators
{
    public class ValidateCreationDoctorSchedule
    {
        public void Validate(DoctorSchedules doctorSchedules)
        {
            BaseValidator.ValidateID(doctorSchedules.Id, nameof(doctorSchedules.Id));
            BaseValidator.ValidateID(doctorSchedules.DoctorId, nameof(doctorSchedules.DoctorId));
        }
    }
}