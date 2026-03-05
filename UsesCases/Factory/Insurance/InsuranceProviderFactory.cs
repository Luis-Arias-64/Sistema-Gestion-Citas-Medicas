using SGCM.Entities.Insurance;
using SGCM.UsesCase.Validators;

namespace SGCM.UsesCase.Factory
{
    public sealed class InsuranceProviderFactory
    {
        public InsuranceProvider Create(string? Name,string? Phone, string? Email, string? Address,string? City, string? Town, short? ZipCode, string? Country, 
                           string? Website, string? ContanctCenter)
        {
            BaseValidator.NotNull(Name, nameof(Name));
            BaseValidator.NotNull(Phone, nameof(Phone));
            BaseValidator.NotNull(Email, nameof(Email));
            BaseValidator.NotNull(City, nameof(City));
            BaseValidator.NotNull(Country, nameof(Country));
            BaseValidator.NotNull(ContanctCenter, nameof(ContanctCenter));
        
            return new InsuranceProvider()
            {
                Name = Name,
                Phone = Phone,
                Email = Email,
                Address = Address,
                City = City,
                Town = Town,
                ZipCode = ZipCode,
                Country = Country,
                Website = Website,
                ContanctCenter = ContanctCenter  
            };
        }
    }
}