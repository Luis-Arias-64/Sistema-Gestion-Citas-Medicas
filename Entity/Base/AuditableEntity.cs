namespace SGCM.Entities.Base
{
    public abstract class AuditableEntity<Tkey> : BaseEntity<Tkey>{
        protected DateTime Create_at {get; init;}
        protected int created_By {get; set;}
        protected DateTime? Update_at {get; set;}
        protected int Update_By {get;set;}
        public AuditableEntity()
        {
            this.Create_at = DateTime.UtcNow;
            this.Update_at = null;
        }
    }
}