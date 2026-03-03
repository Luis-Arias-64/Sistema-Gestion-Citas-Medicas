using SGCM.Entities.Enums;

namespace SGCM.Entities.Users
{
    public class CreatePatient
    {
        public static Patient Create(string FirstName, string LastName, Gender gender, string Phone, string Email, string PasswordHash, DateTime DateOfBirh, 
        short InsurancePlanId, string IdentificationNumber,BloodType bloodType, string EmergencyName, string EmergencyPhone)
        {

            return new Patient()
            {
              FirstName = FirstName,
              LastName = LastName,
              gender = gender,
              Phone = Phone,
              Email = Email,
              PasswordHash = PasswordHash,
              DateOfBirth = DateOfBirh,
              typeUser = TypeUser.Patient,
              InsurancePlanId = InsurancePlanId,
              IdentificationNumber = IdentificationNumber,
              TypeOfBlood = bloodType,
              EmergencyName = EmergencyName,
              EmergencyPhone = EmergencyPhone
            };
        }
    }
}