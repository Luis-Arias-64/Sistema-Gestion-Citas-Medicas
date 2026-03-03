using SGCM.Entities.Appointments;

namespace SGCM.Entities.Validators
{
    public static class ValidateCreationMedicalRecord
    {
        public static void Validate(MedicalRecords medicalRecords)
        {
            BaseValidator.ValidateID(medicalRecords.Id, nameof(medicalRecords.Id));
            BaseValidator.ValidateID(medicalRecords.PatientId, nameof(medicalRecords.PatientId));
            BaseValidator.NotNull(medicalRecords.Diagnosis, nameof(medicalRecords.Diagnosis));
            BaseValidator.NotNull(medicalRecords.Treatment, nameof(medicalRecords.Treatment));
        }
    }
}