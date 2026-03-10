using SGCM.UsesCase.DTOs;
using SGCM.Entities.Users;

namespace SGCM.UsesCase.Mappers
{
    public static class PatientMapper
    {
        public static PatientResponseDTO MapDto(Patient p) => new()
        {
            FirstName = p.FirstName,
            LastName = p.LastName,
            Gender = p.Gender,

            TypeOfBlood = p.TypeOfBlood,
            EmergencyName = p.EmergencyName,
            EmergencyPhone = p.EmergencyPhone,
        };
    }
}