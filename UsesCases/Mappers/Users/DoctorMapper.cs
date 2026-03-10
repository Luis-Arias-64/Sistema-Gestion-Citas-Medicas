using SGCM.UsesCase.DTOs;
using SGCM.Entities.Users;

namespace SGCM.UsesCase.Mappers
{
    public static class DoctorMapper
    {
        public static DoctorResponseDTO MapDto(Doctor p) => new()
        {
            FirstName = p.FirstName,
            LastName = p.LastName,
            Gender = p.Gender,
            
            LicenceNumber = p.LicenceNumber
        };
    }
}