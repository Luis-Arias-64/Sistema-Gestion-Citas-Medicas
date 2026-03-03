using SGCM.Entities.Base;
using SGCM.Entities.Users;

namespace SGCM.Entities.Appointments
{
    public sealed class MedicalRecords : AuditableEntity<int>
    {
        public int PatientId  {get; init;}
        public string? Diagnosis {get; init;}
        public string? Treatment {get; init;}
    }
}