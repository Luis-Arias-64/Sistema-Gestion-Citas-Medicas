using SGCM.Entities.Insurance;
using SGCM.UsesCase.DTOs;
using SGCM.UsesCase.Validators;

namespace SGCM.UsesCase.Factory
{
    public sealed class InsuranceProviderFactory
    {
        public InsuranceProvider Create(CreateInsuranceProviderDTO createInsuranceProviderDTO)
        {
            BaseValidator.NotNull(createInsuranceProviderDTO.Name, nameof(createInsuranceProviderDTO.Name));
            BaseValidator.NotNull(createInsuranceProviderDTO.PhoneNumber, nameof(createInsuranceProviderDTO.PhoneNumber));
            BaseValidator.NotNull(createInsuranceProviderDTO.Email, nameof(createInsuranceProviderDTO.Email));
            BaseValidator.NotNull(createInsuranceProviderDTO.City, nameof(createInsuranceProviderDTO.City));
            BaseValidator.NotNull(createInsuranceProviderDTO.Country, nameof(createInsuranceProviderDTO.Country));
            BaseValidator.NotNull(createInsuranceProviderDTO.ContactCenterPhone, nameof(createInsuranceProviderDTO.ContactCenterPhone));
        
            return new InsuranceProvider()
            {
                Name = createInsuranceProviderDTO.Name,
                Phone = createInsuranceProviderDTO.PhoneNumber,
                Email = createInsuranceProviderDTO.Email,
                Address = createInsuranceProviderDTO.Address,
                City = createInsuranceProviderDTO.City,
                Town = createInsuranceProviderDTO.Town,
                ZipCode = createInsuranceProviderDTO.ZipCode,
                Country = createInsuranceProviderDTO.Country,
                Website = createInsuranceProviderDTO.Website,
                ContanctCenter = createInsuranceProviderDTO.ContactCenterPhone  
            };
        }
    }
}