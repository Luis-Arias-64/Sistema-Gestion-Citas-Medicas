using SGCM.Domain.Repository;

namespace SGCM.Domain.Entities
{
    public sealed class HospitalPersonal : Person , HospitalPersonalRepository
    {
        private string rol {get;set;}
        public HospitalPersonal(string name,int age, int identifycation, string? mail, int? phoneNumber,string rol) : base(name, age, identifycation, mail, phoneNumber)
        {
        }

        public void CreateHospitalPersonal(HospitalPersonal hospitalPersonal)
        {
            
        }
        public void EliminareHospitalPersonal(int hospitalPersonal_id)
        {
            
        }
        public void ModifiHospitalPersonal(int hospitalPersonal_id)
        {
            
        }

        public List<HospitalPersonal> listHospitalPersonal()
        {
            return null;
        }
    }    
}