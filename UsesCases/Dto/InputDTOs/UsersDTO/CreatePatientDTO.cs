using SGCM.Entities.Enums;
using SGCM.UsesCase.DTOs.Input;

namespace SGCM.UsesCase.DTOs
{
    public record CreatePatientDTO : PersonDTO
    { 
        public short InsurancePlanId {get; set;}
        public string IdentificationNumber {get; init;} = default!;
        public BloodType TypeOfBlood {get; init;}
        public string EmergencyName {get; init;} = default!; 
        public string EmergencyPhone {get; init;} = default!;
    }
}