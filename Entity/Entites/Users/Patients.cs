using SGCM.Entities.Insurance;
using SGCM.Entities.Enums;
namespace SGCM.Entities.Users
{
    public sealed class Patient : Person
    { 
        public short InsurancePlanId {get; init;}
        public InsurancePlan? InsurancePlan {get; init;}

        public string IdentificationNumber {get; init;}
        public BloodType TypeOfBlood {get; init;}
        public string EmergencyName {get; init;}
        public string EmergencyPhone {get; init;}

        public Patient(string FirstName, string LastName, Gender gender, string Phone, string Email, string PasswordHash, DateTime DateOfBirth,short InsurancePlanId, string IdentificationNumber, 
        BloodType TypeOfBlood, string EmergencyName, string EmergencyPhone ) : base(FirstName,LastName,gender,Phone, Email, PasswordHash,DateOfBirth)
        {
           this.InsurancePlanId = InsurancePlanId;
           this.IdentificationNumber = IdentificationNumber;
           this.TypeOfBlood = TypeOfBlood;
           this.EmergencyName = EmergencyName;
           this.EmergencyPhone = EmergencyPhone; 
        }
    }   
}