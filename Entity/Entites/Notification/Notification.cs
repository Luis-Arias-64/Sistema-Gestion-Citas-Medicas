using SGCM.Entities.Base;

namespace SGCM.Entities.Notification
{
    public sealed class Notification : AuditableEntity<int>
    {
        public Enum? NotificationStatus {get; init;}
        public short NotificationStatusId {get; init;}

        public string? Email {get; init;}
        public string? TypeNotification {get; init;}
        public string? Description {get; init;}
        public DateTime SendedAt {get; init;}
    }
}