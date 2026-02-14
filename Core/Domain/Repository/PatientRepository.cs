using SGCM.Domain.Entities;

namespace SGCM.Domain.Repository
{
    public interface PatientRepository
    {
        public bool CreatePatient(Patient patient);
        public bool ModifiPatient(Patient patient);
        public bool ElimatePatient(int PatientID);
        public List<Patient> AllPatient();
        Patient SearchforID(Patient patient);
    }
}