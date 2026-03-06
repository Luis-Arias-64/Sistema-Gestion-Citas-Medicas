using SGCM.Entities.Appointments;
using SGCM.Entities.Users;

namespace SGCM.UsesCase.Repository
{
    public interface IDoctorRepository : IBaseUsersRepository<Doctor, short>
    {
        Task<IEnumerable<DoctorSchedules>> GetDoctorSchedulesAsync(short doctorId, CancellationToken ct = default);
    }
}