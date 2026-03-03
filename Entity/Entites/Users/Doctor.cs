using SGCM.Entities.Enums;
namespace SGCM.Entities.Users
{
    public sealed class Doctor : Person 
    {   
        public short EspecialityId {get; init;}
        public string LicenceNumber {get; init;}
        public DateTime LicenceExpiration {get; init;}
        public DateTime EmploymentStartDate {get; init;}
        public Doctor(string FirstName, string LastName, Gender gender, string Phone, string Email, string PasswordHash, DateTime DateOfBirth, short EspecialityId,
        string LicenceNumber, DateTime LicenceExpiration, DateTime EmploymentStartDate) : 
        base(FirstName,LastName,gender,Phone, Email, PasswordHash,DateOfBirth)
        {
            this.EspecialityId = EspecialityId;
            this.LicenceNumber = LicenceNumber;
            this.LicenceExpiration = LicenceExpiration;
            this.EmploymentStartDate = EmploymentStartDate;
            typeUser = TypeUser.Doctor;
            
        }
    }  
}