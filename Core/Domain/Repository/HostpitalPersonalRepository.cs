using SGCM.Domain.Entities;

namespace SGCM.Domain.Repository
{
    public interface HospitalPersonalRepository
    {
        public void CreateHospitalPersonal(HospitalPersonal hospitalPersonal);
        public void EliminareHospitalPersonal(int hospitalPersonal_id);
        public void ModifiHospitalPersonal(int hospitalPersonal_id);
        public List<HospitalPersonal> listHospitalPersonal();
    }
}