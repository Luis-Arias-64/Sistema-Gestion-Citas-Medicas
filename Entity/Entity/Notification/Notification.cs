using SGCM.Entities.Base;

namespace SGCM.Entities.Notifications
{
    public sealed class Notification : AuditableEntity<int>
    {
        public Enum? NotificationStatus {get; private set;}

        public string? Email {get; init;}
        public string? TypeNotification {get; init;}
        public string? Description {get; init;}
        public DateTime SendedAt {get; init;}
    }
}