using SGCM.Entities.Users;
using SGCM.UsesCase.DTOs;

namespace SGCM.UsesCase.Mappers
{
    public static class PersonalMapper
    {
        public static PersonalResponseDTO (Personal p) => new(){
            FirstName = p.FirstName
        }
                    
    };
}
