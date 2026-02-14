using SGCM.Domain.Entities;

namespace SGCM.Domain.Repository
{
    public interface InsuranceProviderRepository
    {
        public void CreateInsurance(InsuranceProvider insurance);
        public void ModifiInsurance(int Insurance_id);
        public void EliminateInsurance(int Insurance_id);
        public List<InsuranceProvider> listInsurence();
    } 
}