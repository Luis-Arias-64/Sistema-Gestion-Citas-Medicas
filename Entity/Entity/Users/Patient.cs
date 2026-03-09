using SGCM.Entities.Insurance;
using SGCM.Entities.Enums;
namespace SGCM.Entities.Users
{
    public sealed class Patient : Person
    { 
        public short InsurancePlanId {get; set;} 
        public string IdentificationNumber {get; set;} = default!;
        public BloodType TypeOfBlood {get; set;}
        public string EmergencyName {get; set;} = default!;
        public string EmergencyPhone {get; set;} = default!;
    }   
}