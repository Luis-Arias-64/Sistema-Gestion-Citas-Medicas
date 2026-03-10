using SGCM.UsesCase.DTOs;
using SGCM.UsesCase.Factory;
using SGCM.UsesCase.Repository;
using SGCM.UsesCase.Interfaces.Logger;
using SGCM.Entities.Users;
using SGCM.UsesCase.Validators;
using SGCM.UsesCase.Base;
using SGCM.UsesCase.Mappers;

namespace SGCM.UsesCase.Features.UserRegister
{
    public sealed class PatientRegistrer
    {
        private readonly IPatientRepository _repository;
        private readonly IInsurancePlanProviderRepository _insurancePlan;
        private readonly IBaseLogger<Patient> _logger;

        public PatientRegistrer(IPatientRepository repository, IBaseLogger<Patient> logger,IInsurancePlanProviderRepository planProvider)
        {
            _repository = repository;
            _logger = logger;
            _insurancePlan = planProvider;
        }
        public async Task<OperationResult<PatientResponseDTO>> RegisterPatient(CreatePatientDTO dTO)
        {
            try
            {
                if (await _repository.IdentificationExitsAsync(dTO.IdentificationNumber))
                {
                    return OperationResult<PatientResponseDTO>.CustomError("This identification already number exists");
                }
                if (!await _insurancePlan.ExistsAsync(dTO.InsurancePlanId))
                {
                    return OperationResult<PatientResponseDTO>.CustomError("This insurance plan doesnt exists");
                }
                if (await _repository.EmailExistsAsync(dTO.Email))
                {
                    return OperationResult<PatientResponseDTO>.CustomError("This email address already exists");
                }

                var patientValidate = PatientFactory.Create(dTO);

                var createdPatient = await _repository.AddAsync(patientValidate);

                var dtoMap = PatientMapper.MapDto(createdPatient);

                return OperationResult<PatientResponseDTO>.Success(dtoMap,"Patient created successfully");
            }
            catch(Exception ex)
            {
                return null;
            }
        }    


    }
}