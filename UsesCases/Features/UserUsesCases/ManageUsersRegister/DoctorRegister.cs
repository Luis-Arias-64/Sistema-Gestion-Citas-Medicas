using SGCM.UsesCase.DTOs;
using SGCM.UsesCase.Factory;
using SGCM.UsesCase.Interfaces.Repository;
using SGCM.UsesCase.Interfaces.Logger;
using SGCM.Entities.Users;
using SGCM.UsesCase.Base;
using SGCM.UsesCase.Mappers;

namespace SGCM.UsesCase.Features.UserRegister
{
    public sealed class DoctorRegister
    {
        private readonly IDoctorRepository _repository;
        private readonly IDoctorSpecialitiesRepository _doctorSpecialities;
        private readonly IBaseLogger<Doctor> _logger;

        public DoctorRegister(IDoctorRepository repository, IDoctorSpecialitiesRepository doctorSpecialities, IBaseLogger<Doctor> logger)
        {
            _repository = repository;
            _doctorSpecialities = doctorSpecialities;
            _logger = logger;
        }
        public async Task<OperationResult<DoctorResponseDTO>> RegisterDoctor(CreateDoctorDTO dTO)
        {
            try
            {
                if (await _repository.LicenceNumberExistAsync(dTO.LicenceNumber))
                {
                    return OperationResult<DoctorResponseDTO>.CustomError("Identification number already exists");
                }
                if (dTO.LicenceExpiration < DateTime.UtcNow)
                {
                    return OperationResult<DoctorResponseDTO>.CustomError("The license is expired");
                }
                if (await _repository.EmailExistsAsync(dTO.Email))
                {
                    return OperationResult<DoctorResponseDTO>.CustomError("Email address already exists");
                }
                if (!await _doctorSpecialities.ExistsAsync(dTO.EspecialityId))
                {
                    return OperationResult<DoctorResponseDTO>.CustomError("The speciality does not exists");
                }

                var doctor = DoctorFactory.Create(dTO);

                await _logger.LogInformationAsync("Registering new doctor");

                var createdDoctor = await _repository.AddAsync(doctor);

                var dtoMap = DoctorMapper.MapDto(createdDoctor);

                return OperationResult<DoctorResponseDTO>.Success(dtoMap,"Doctor created successfully");
            }
            catch(Exception ex)
            {
                await _logger.LogErrorAsync("Error registering Doctor", ex);

                return OperationResult<DoctorResponseDTO>.Failure("Unexpected error occurred");
            }
        }    
    }
}