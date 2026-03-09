using SGCM.Entities.Base;
using SGCM.Entities.Users;

namespace SGCM.Entities.Appointments
{
    public sealed class MedicalRecord : AuditableEntity<int>
    {
        public int PatientId  {get; set;}
        public string Diagnosis {get; set;} = default!;
        public string Treatment {get; set;} = default!;
    }
}