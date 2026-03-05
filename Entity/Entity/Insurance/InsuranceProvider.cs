using System.ComponentModel.DataAnnotations;
using SGCM.Entities.Base;
namespace SGCM.Entities.Insurance
{
    public sealed class InsuranceProvider : AuditableEntity<int>
    {
        public string? Name { get; init; }
        public string? Phone { get; init; }
        public string? Email { get; init; }
        public string? Address { get; init; }
        public string? City { get; init; }
        public string? Town {get; init;}
        public short? ZipCode {get; init;}
        public string? Country {get; init;}
        public string? Website {get; init;}
        public string? ContanctCenter {get; init;}
    }
}