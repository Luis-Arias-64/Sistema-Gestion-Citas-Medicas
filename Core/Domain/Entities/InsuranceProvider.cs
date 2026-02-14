using System.ComponentModel.DataAnnotations;
using SGCM.Domain.Entities.Enum;
using SGCM.Domain.Repository;
namespace SGCM.Domain.Entities
{
    public class InsuranceProvider : InsuranceProviderRepository
    {
        private string name {get;set;}
        private int phoneNumber {get;set;}
        private string address{get;set;}
        private string descrption {get;set;}
        private InsuranceProviderState insuranceProviderState {get;set;}
        public InsuranceProvider(string name,int phoneNumber, string address, string descrption)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.descrption = descrption;
        }
        public void CreateInsurance(InsuranceProvider insurance)
        {
            
        }
        public void ModifiInsurance(int Insurance_id)
        {
            
        }
        public void EliminateInsurance(int Insurance_id)
        {
            
        }
        public List<InsuranceProvider> listInsurence()
        {
            return null;
        }
    }
}