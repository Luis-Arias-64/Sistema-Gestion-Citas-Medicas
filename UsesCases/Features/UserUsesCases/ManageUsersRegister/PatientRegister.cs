using SGCM.UsesCase.DTOs;
using SGCM.UsesCase.Factory;
using SGCM.UsesCase.Interfaces.Repository;
using SGCM.UsesCase.Interfaces.Logger;
using SGCM.Entities.Users;
using SGCM.UsesCase.Base;
using SGCM.UsesCase.Mappers;

namespace SGCM.UsesCase.Features.UserRegister
{
    public sealed class PatientRegister
    {
        private readonly IPatientRepository _repository;
        private readonly IInsurancePlanProviderRepository _insurancePlan;
        private readonly IBaseLogger<Patient> _logger;
        public PatientRegister(IPatientRepository repository, IBaseLogger<Patient> logger,IInsurancePlanProviderRepository planProvider)
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
                    return OperationResult<PatientResponseDTO>.CustomError("Identification number already exists");
                }
                if (!await _insurancePlan.ExistsAsync(dTO.InsurancePlanId))
                {
                    return OperationResult<PatientResponseDTO>.CustomError("Insurance plan does not exists");
                }
                if (await _repository.EmailExistsAsync(dTO.Email))
                {
                    return OperationResult<PatientResponseDTO>.CustomError("Email address already exists");
                }

                var patient = PatientFactory.Create(dTO);

                await _logger.LogInformationAsync("Registering new patient");

                var createdPatient = await _repository.AddAsync(patient);

                var dtoMap = PatientMapper.MapDto(createdPatient);

                return OperationResult<PatientResponseDTO>.Success(dtoMap,"Patient created successfully");
            }
            catch(Exception ex)
            {
                await _logger.LogErrorAsync("Error registering patient", ex);

                return OperationResult<PatientResponseDTO>.Failure("Unexpected error occurred");
            }
        }    
    }
}