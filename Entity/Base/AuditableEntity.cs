namespace SGCM.Entities.Base
{
    public abstract class AuditableEntity<Tkey> : BaseEntity<Tkey>{
        protected DateTime create_at {get; private set;}
        protected DateTime? update_at {get; private set;}

        public AuditableEntity()
        {
            this.create_at = DateTime.UtcNow;
            this.update_at = null;
        }
    }
}