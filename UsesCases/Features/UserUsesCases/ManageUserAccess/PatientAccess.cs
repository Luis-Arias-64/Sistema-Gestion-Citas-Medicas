using SGCM.Entities.Users;
using SGCM.UsesCase.Repository;

namespace SGCM.UsesCase.Features.UserAccess
{
    public class PatientAccess 
    {
        public readonly IPatientRepository _context;
        
        public PatientAccess(IPatientRepository patientRepository)
        {
            patientRepository = _context;
        }

        



    }
}