using System.Security.Cryptography.X509Certificates;

namespace SGCM.Entities.Base
{
    public abstract class BaseEntity<Tkey>
    {
        public Tkey? Id {get;set;}
        public DateTime? DeletedAt {get;set;}

        public BaseEntity(){
            this.DeletedAt = null;
        }
    }
}