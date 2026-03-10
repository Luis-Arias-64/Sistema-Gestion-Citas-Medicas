using SGCM.Entities.Enums;
using SGCM.UsesCase.DTOs.Input;

namespace SGCM.UsesCase.DTOs
{
    public record CreatePersonalDTO : PersonDTO
    {
        public Rolename Role {get;set;}
    }
}