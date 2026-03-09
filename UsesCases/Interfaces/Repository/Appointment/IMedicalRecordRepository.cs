using SGCM.Entities.Appointments;

namespace SGCM.UsesCase.Repository
{
    public interface IMedicalRecordRepository : IBaseRepository<MedicalRecord, int>
    {
        Task<IEnumerable<MedicalRecord>> GetAllMedicalRecordbyPatientIdAsync(int patientId, CancellationToken ct = default);
    }
}