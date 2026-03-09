using SGCM.Entities.Notifications;
using SGCM.UsesCase.Validators;

namespace SGCM.UsesCase.Factory
{
    public sealed class NotificationFactory
    {
        public Notification Create(string Email, string TypeNotification, string Description, DateTime SendedAt)
        {
            BaseValidator.NotNull(Email, nameof(Email));
            BaseValidator.NotNull(TypeNotification, nameof(TypeNotification));
            BaseValidator.NotNull(Description, nameof(Description));

            return new Notification()
            {
              Email = Email,
              TypeNotification = TypeNotification,
              Description = Description,
              SendedAt = SendedAt
            };
        }
    }
}