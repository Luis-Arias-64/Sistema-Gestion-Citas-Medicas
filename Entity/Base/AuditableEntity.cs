namespace SGCM.Entities.Base
{
    public abstract class AuditableEntity<Tkey> : BaseEntity<Tkey>{
        protected DateTime Create_at {get; init;}
        protected DateTime? Update_at {get; private set;}
        public AuditableEntity()
        {
            this.Create_at = DateTime.UtcNow;
            this.Update_at = null;
        }
    }
}