using SGCM.Entities.Insurance;
using SGCM.Entities.Enums;
namespace SGCM.Entities.Users
{
    public sealed class Patient : Person
    { 
        public short InsurancePlanId {get; init;} 
        public string? IdentificationNumber {get; init;}
        public BloodType TypeOfBlood {get; init;}
        public string? EmergencyName {get; init;}
        public string? EmergencyPhone {get; init;}
    }   
}