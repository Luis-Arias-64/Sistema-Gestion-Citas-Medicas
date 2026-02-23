namespace SGCM.Domain.Base
{
    public class AuditableEntity<Tkey> : BaseEntity<Tkey>{
        public bool Status {get;set;}
        public DateTime CreatedAt {get;set;}
        public DateTime UpdateAt {get;set;}
    }
}