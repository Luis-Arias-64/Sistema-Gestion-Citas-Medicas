using SGCM.Entities.Notifications;
namespace SGCM.Entities.Validators
{
    public static class ValidateCreationNotification
    {
        public static void Validate(Notification notification)
        {
            BaseValidator.ValidateID(notification.Id, nameof(notification.Id));
            BaseValidator.NotNull(notification.Email, nameof(notification.Email));
            BaseValidator.NotNull(notification.TypeNotification, nameof(notification.TypeNotification));
            BaseValidator.NotNull(notification.Description, nameof(notification.Description));
        }
    }
}