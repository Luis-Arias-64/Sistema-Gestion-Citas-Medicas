namespace SGCM.Entities.Users
{
    public sealed class Doctor : Person 
    {   
        public short EspecialityId {get; set;}
        public string LicenceNumber {get; set;} = default!;
        public DateTime LicenceExpiration {get; set;}
        public DateTime EmploymentStartDate {get; set;}
    }  
}