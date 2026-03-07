using System.ComponentModel.DataAnnotations;
using SGCM.Entities.Base;
using SGCM.Entities.Enums;

namespace SGCM.Entities.Users
{
    public abstract class Person : AuditableEntity<int>
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; } 
        public Gender gender { get; init; }
        public string? Phone { get; init; }
        public string? Email {get; init;}
        public string? PasswordHash {get; init;}
        public DateTime DateOfBirth { get; init; }
        public TypeUser typeOfUser {get; init;}
    } 
}