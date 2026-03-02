using SGCM.Entities.Enums;
namespace SGCM.Entities.Users
{
    public sealed class Personal : Person
    {
        public Rolename Role {get; init;}
        public TypeUser typeUser {get; init;}

        public  Personal(string FirstName, string LastName, Gender gender, string Phone, string Email, string PasswordHash, DateTime DateOfBirth) : 
        base(FirstName,LastName,gender,Phone, Email, PasswordHash,DateOfBirth)
        {

        }
    }    
}