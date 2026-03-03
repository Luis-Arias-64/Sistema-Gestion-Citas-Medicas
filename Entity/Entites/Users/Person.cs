using System.ComponentModel.DataAnnotations;
using SGCM.Entities.Base;
using SGCM.Entities.Enums;

namespace SGCM.Entities.Users
{
    public abstract class Person : AuditableEntity<int>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; } 
        public Gender gender { get; init; }
        public string Phone { get; init; }
        public string Email {get; init;}
        public string PasswordHash {get; init;}
        public DateTime DateOfBirth { get; init; }
        public TypeUser typeUser {get; init;}
        public Person(string FirstName, string LastName, Gender gender, string Phone, string Email, string PasswordHash, DateTime DateOfBirth) : base()
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.gender = gender;
            this.Phone = Phone;
            this.Email = Email;
            this.PasswordHash = PasswordHash;
            this.DateOfBirth = DateOfBirth;
        }
    } 
}