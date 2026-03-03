using SGCM.Entities.Enums;
namespace SGCM.Entities.Users
{
    public sealed class Doctor : Person 
    {   
        public short EspecialityId {get; init;}
        public string LicenceNumber {get; init;}
        public DateTime LicenceExpiration {get; init;}
        public DateTime EmploymentStartDate {get; init;}

    }  
}