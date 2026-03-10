using SGCM.Entities.Enums;

namespace SGCM.UsesCase.DTOs
{
    public record PersonResposeDTO
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public GenderOfUser Gender { get; set; }
    }
}