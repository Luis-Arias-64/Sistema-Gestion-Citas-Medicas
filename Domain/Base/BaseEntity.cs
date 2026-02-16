namespace SGCM.Domain.Base
{
    public abstract class BaseEntity
    {
        public DateTime CreationDate {get;set;}
        public DateTime? ModificationDate {get;set;}
        public bool Status {get;set;}
    }
}