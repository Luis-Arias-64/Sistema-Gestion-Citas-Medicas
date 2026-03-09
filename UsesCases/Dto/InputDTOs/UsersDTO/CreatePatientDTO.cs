using SGCM.Entities.Enums;

namespace SGCM.UsesCase.DTOs
{
    public record CreatePatientDTO
    { 
        public string FirstName { get; init; } = default!;
        public string LastName { get; init; } = default!;
        public GenderOfUser Gender { get; init; }
        public string Phone { get; init; } = default!;
        public string Email {get; init;} = default!;
        public string Password {get; init;} = default!;
        public DateTime DateOfBirth { get; init;}

        public short InsurancePlanId {get; set;}
        public string IdentificationNumber {get; init;} = default!;
        public BloodType TypeOfBlood {get; init;}
        public string EmergencyName {get; init;} = default!; 
        public string EmergencyPhone {get; init;} = default!;
    }
}