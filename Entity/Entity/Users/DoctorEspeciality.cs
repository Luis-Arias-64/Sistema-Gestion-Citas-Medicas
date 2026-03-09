using SGCM.Entities.Base;
namespace SGCM.Entities.Users
{
    public sealed class DoctorEspeciality : BaseEntity<short>
    {
        public string EspecialityName {get; set;} = default!;
    }
}