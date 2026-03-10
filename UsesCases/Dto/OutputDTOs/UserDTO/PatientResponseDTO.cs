using SGCM.Entities.Enums;

namespace SGCM.UsesCase.DTOs
{
    public record PatientResponseDTO : PersonResposeDTO
    {
        public BloodType TypeOfBlood {get;set;}
        public string EmergencyName {get; set;} = default!; 
        public string EmergencyPhone {get; set;} = default!;
    }
}