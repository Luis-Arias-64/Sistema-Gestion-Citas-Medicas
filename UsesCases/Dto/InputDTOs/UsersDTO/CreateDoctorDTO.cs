using SGCM.Entities.Enums;
using SGCM.UsesCase.DTOs.Input;

namespace SGCM.UsesCase.DTOs
{
    public record CreateDoctorDTO : PersonDTO
    {
        public short EspecialityId {get; set;}
        public string LicenceNumber {get; init;} = default!;
        public DateTime LicenceExpiration {get; init;}
        public DateTime EmploymentStartDate {get; init;}
    }
}