using SGCM.Entities.Users;

namespace SGCM.UsesCase.Interfaces.Repository
{
    public interface IDoctorSpecialitiesRepository : IBaseRepository<DoctorEspeciality,short>
    {
        Task<IEnumerable<Doctor>> GetDoctorsBySpecialityAsync(short doctorEspecialityId, CancellationToken ct = default);
        Task<bool> ChangeEspecialityToDoctorAsync(short doctorId, short doctorEspecialityId, CancellationToken ct = default);
    }
}