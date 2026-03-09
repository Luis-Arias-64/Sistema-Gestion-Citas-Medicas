using SGCM.Entities.Enums;

namespace SGCM.UsesCase.DTOs
{
    public record CreateDoctorDTO
    {
        public string FirstName { get; init; } = default!;
        public string LastName { get; init; } = default!;
        public GenderOfUser Gender { get; init; }
        public string Phone { get; init; } = default!;
        public string Email {get; init;} = default!;
        public string Password {get; init;} = default!;
        public DateTime DateOfBirth { get; init; }

        public short EspecialityId {get; set;}
        public string LicenceNumber {get; init;} = default!;
        public DateTime LicenceExpiration {get; init;}
        public DateTime EmploymentStartDate {get; init;}
    }
}