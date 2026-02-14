namespace SGCM.Domain.Entities
{
    public sealed class Patient : Person
    {
        private InsuranceProvider insurance;
        public Patient(string name,int age, int identifycation, string? mail, int? phoneNumber,InsuranceProvider insurance) : base(name, age, identifycation, mail, phoneNumber)
        {
            this.insurance = insurance;
        }

        
    }   
}