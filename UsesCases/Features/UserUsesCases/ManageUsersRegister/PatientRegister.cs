using SGCM.UsesCase.DTOs;
using SGCM.UsesCase.Factory;
using SGCM.UsesCase.Repository;
using SGCM.UsesCase.Interfaces.Logger;
using SGCM.Entities.Users;

namespace SGCM.UsesCase.Features.UserRegister
{
    public sealed class PatientRegistrer
    {
        public readonly IPatientRepository _repository;
        public readonly IBaseLogger<Patient> _logger;

        public PatientRegistrer(IPatientRepository repository, IBaseLogger<Patient> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task RegisterPatient(CreatePatientDTO dTO)
        {
            try
            {
                PatientFactory.Create(dTO);



            }
            catch(Exception ex)
            {
                
            }    
        }
    }
}