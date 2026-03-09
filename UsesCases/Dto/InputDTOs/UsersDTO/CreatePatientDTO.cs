using SGCM.Entities.Enums;

namespace SGCM.UsesCase.DTOs
{
    public record CreatePatientDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; } 
        public Gender Gender { get; set; }
        public string? Phone { get; set; }
        public string Email {get; set;}
        public string Password {get; set;}
        public DateTime DateOfBirth { get; init; }
        public TypeUser TypeOfUser {get; init;}
    }
}