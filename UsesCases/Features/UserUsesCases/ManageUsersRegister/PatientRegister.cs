using SGCM.UsesCase.DTOs;
using SGCM.UsesCase.Factory;
using SGCM.UsesCase.Repository;

namespace SGCM.UsesCase.Features.UserRegister
{
    public sealed class PatientRegistrer
    {
        public readonly IPatientRepository _Context;

        public PatientRegistrer(IPatientRepository patient)
        {
            this._Context = patient;
        }

        public async Task RegisterPatient(CreatePatientDTO createPatientDTO)
        {
            PatientFactory patientFactory
        }
    }
}