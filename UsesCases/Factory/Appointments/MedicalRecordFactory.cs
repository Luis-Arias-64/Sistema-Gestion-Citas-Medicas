using SGCM.Entities.Appointments;

namespace SGCM.UsesCase.Validators
{
    public sealed class ValidateCreationMedicalRecord
    {
        public MedicalRecord Create(int PatientId, string Diagnosis, string Treatment)
        {
            BaseValidator.ValidateID(PatientId, nameof(PatientId));
            BaseValidator.NotNull(Diagnosis, nameof(Diagnosis));
            BaseValidator.NotNull(Treatment, nameof(Treatment));

            return new MedicalRecord()
            {
                PatientId = PatientId,
                Diagnosis = Diagnosis,
                Treatment = Treatment
            };
        }
    }
}