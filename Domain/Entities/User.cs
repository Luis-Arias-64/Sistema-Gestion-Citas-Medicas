using System.Data.Common;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using SGCM.Domain.Base;

namespace SGCM.Domain.Entities
{
    public abstract class Person : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Identificaion { get; set; }
        public string? Address { get; set; }
        public string? TypeBlood {get;set;}
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public DateTime Birth { get; set; }
    } 
}