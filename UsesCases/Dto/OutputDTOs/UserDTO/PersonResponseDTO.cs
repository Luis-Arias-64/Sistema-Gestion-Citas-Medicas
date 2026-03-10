using SGCM.Entities.Enums;

namespace SGCM.UsesCase.DTOs
{
    public record PersonResposeDTO
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public GenderOfUser Gender { get; set; }
        public string Phone { get; set; } = default!;
        public DateTime DateOfBirth { get; set; }
        public BloodType TypeOfBlood {get;set;}
    }
}