using SGCM.Entities.Appointments;
using SGCM.Entities.Users;

namespace SGCM.UsesCase.Interfaces.Repository
{
    public interface IDoctorRepository : IBaseUsersRepository<Doctor, short>
    {
        Task<IEnumerable<DoctorSchedules>> GetDoctorSchedulesAsync(short doctorId);
        Task<bool> LicenceNumberExistAsync(string Email);
    }
}