using SGCM.Entities.Enums;

namespace SGCM.UsesCase.DTOs
{
    public record CreatePersonalDTO
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public GenderOfUser Gender { get; set; }
        public string Phone { get; set; } = default!;
        public string Email {get; set;} = default!;
        public string Password {get; set;} = default!;
        public DateTime DateOfBirth { get; set; }
        public Rolename Role {get;set;}
    }
}