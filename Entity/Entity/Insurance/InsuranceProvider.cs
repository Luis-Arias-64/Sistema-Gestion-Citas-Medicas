using System.ComponentModel.DataAnnotations;
using SGCM.Entities.Base;
namespace SGCM.Entities.Insurance
{
    public sealed class InsuranceProvider : AuditableEntity<int>
    {
        public string Name { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Town {get; set;} = default!;
        public short ZipCode {get; set;}
        public string Country {get; set;} = default!;
        public string Website {get; set;} = default!;
        public string ContanctCenter {get; set;} = default!;
    }
}