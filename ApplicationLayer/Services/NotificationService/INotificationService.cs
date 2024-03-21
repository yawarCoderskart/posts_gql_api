

using Posts_graphql.Domain.Models;
namespace Posts_graphql.Application.Services
{
    public interface INotificationService
    {
        Task<List<Notification>> GetNotificationById(int? NotificationId);
        Task<Notification> AddEditNotification(Notification newNotification);
    }

}
