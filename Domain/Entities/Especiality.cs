namespace SGCM.Domain.Entities
{
    public class Especiality
    {
        private List<Doctor> DoctorList {get;set;}
        private string especiality {get;set;}
        public Especiality(string especiality)
        {
            this.especiality = especiality;
        }

        public void AddDoctors(Doctor doctor)
        {
            DoctorList.Add(doctor);
        }

        public void EliminateDoctor()
        {
        }

        public Doctor SearchDoctor(Doctor doctor)
        {
            return null;
        }
        
        public void ListDoctors()
        {
            foreach (var doctor in DoctorList)
            {
                Console.WriteLine(doctor.ToString());
            }
        }
    }
}