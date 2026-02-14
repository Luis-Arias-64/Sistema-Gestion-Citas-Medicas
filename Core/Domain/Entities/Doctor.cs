using SGCM.Domain.Repository;

namespace SGCM.Domain.Entities
{
    public sealed class Doctor : Person , DoctorReposity
    {   
        private int doctor_id {get; set;}
        private List<Especiality> especialities {get;set;}
        public Doctor(string name,int age, int identifycation, string? mail, int? phoneNumber, Especiality especiality) : base(name, age, identifycation, mail, phoneNumber)
        {
           
        }
        public void CreateDoctor(Doctor doctor)
        {
            
        }
        public void ModifiDoctor(int DoctorID)
        {
                        
        }
        public void  EliminateDoctor(int DoctorID)
        {
            
        }
        public List<Doctor> GetAllDoctors()
        {
            return null;
        }
    }  
}