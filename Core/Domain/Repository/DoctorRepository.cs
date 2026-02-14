using SGCM.Domain.Entities;

namespace SGCM.Domain.Repository
{
    public interface DoctorReposity
    {
        public void CreateDoctor(Doctor doctor);
        public void ModifiDoctor(int DoctorID);
        public void EliminateDoctor(int DoctorID);
        public List<Doctor> GetAllDoctors();
    }
}