using SGCM.Entities.Users;
using SGCM.UsesCase.Base;
using SGCM.UsesCase.DTOs;
using SGCM.UsesCase.Factory;
using SGCM.UsesCase.Interfaces.Logger;
using SGCM.UsesCase.Interfaces.Repository;

namespace SGCM.UsesCase.Features.UserRegister
{
    public class PersonalRegistrer
    {
        private IPersonalRepository _context;
        private IBaseLogger<Personal> _logger;

        public PersonalRegistrer(IPersonalRepository personalRepository, IBaseLogger<Personal> baseLogger)
        {
            _context = personalRepository;
            _logger = baseLogger;
        }

        public async Task<OperationResult<PersonalResponseDTO>> RegisterPersonal(CreatePersonalDTO dTO)
        {
            try
            {
                if (await _context.EmailExistsAsync(dTO.Email))
                {
                    return OperationResult<PersonalResponseDTO>.CustomError("Email already exists");
                }
                
                var personal = PersonalFactory.Create(dTO);

                await _logger.LogInformationAsync("Personal is creating");

                var personalCreate = await _context.AddAsync(personal);

                var dtoMap = Personal

            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

    }
}