using SGCM.Entities.Base;

namespace SGCM.Entities.Notifications
{
    public sealed class Notification : AuditableEntity<int>
    {
        public Enum NotificationStatus {get; set;} = default!;
        public string Email {get; set;} = default!;
        public string TypeNotification {get; set;} = default!;
        public string Description {get; set;} = default!;
        public DateTime SendedAt {get; set;}
    }
}