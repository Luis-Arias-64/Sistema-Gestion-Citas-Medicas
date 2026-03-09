using System.ComponentModel.DataAnnotations;
using SGCM.Entities.Base;
using SGCM.Entities.Enums;

namespace SGCM.Entities.Users
{
    public abstract class Person : AuditableEntity<int>
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public GenderOfUser Gender { get; set; }
        public string Phone { get; set; } = default!;
        public string Email {get; set;} = default!;
        public string Password {get; set;} = default!;
        public DateTime DateOfBirth { get; set; }
    } 
}