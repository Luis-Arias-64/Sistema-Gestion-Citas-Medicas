using System.ComponentModel.DataAnnotations;
using SGCM.Domain.Entities.Enum;
using SGCM.Domain.Repository;
namespace SGCM.Domain.Entities
{
    public class InsuranceProvider 
    {

        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public InsuranceProviderState state {get;set;}
        public string? Address { get; set; }
        public string? City { get; set; }
        public decimal? MaximumCoverage { get; set; }
    }
}