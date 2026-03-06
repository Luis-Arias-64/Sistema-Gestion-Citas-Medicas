using SGCM.Entities.Insurance;
using SGCM.Entities.Users;

namespace SGCM.UsesCase.Repository
{
    public interface IPatientRepository : IBaseUsersRepository<Patient,int>
    {
        Task<bool> PatientHasInsurancePlanExistsAsync(int patientId, CancellationToken ct = default);
        Task<bool> PatientInsuranceCoverdAsync(int patientId, CancellationToken ct = default);
    }
}