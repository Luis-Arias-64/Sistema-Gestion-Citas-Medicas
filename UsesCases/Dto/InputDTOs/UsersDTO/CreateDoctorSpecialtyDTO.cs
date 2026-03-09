using SGCM.Entities.Users;

namespace SGCM.UsesCase.DTOs
{
    public record CreateDoctorSpecialtyDTO
    {
        string EspecialityName {get;set;} = default!;
    }
}